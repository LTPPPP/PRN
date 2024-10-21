using assignment01.Models;
using assignment01.Utilities;
using System.Windows.Input;
namespace assignment01.ViewModels
{
    public class CustomerProfileViewModel : BaseViewModel
    {
        private Customer _customer;
        private bool _isReadOnlyMode = true;
        private bool _isEditMode = false;

        public Customer Customer
        {
            get => _customer;
            set
            {
                _customer = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CustomerStatusDisplay));
            }
        }

        public string CustomerStatusDisplay
        {
            get => Customer?.CustomerStatus == 1 ? "Active" : "Deleted";
        }

        public bool IsReadOnlyMode
        {
            get => _isReadOnlyMode;
            set
            {
                _isReadOnlyMode = value;
                OnPropertyChanged();
            }
        }

        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadCustomerCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand SaveChangesCommand { get; }

        public CustomerProfileViewModel()
        {
            LoadCustomerCommand = new RelayCommand(LoadCustomerData);
            EditCommand = new RelayCommand(EditCustomer);
            SaveChangesCommand = new RelayCommand(SaveCustomerChanges);
        }

        private void LoadCustomerData(object parameter)
        {
            using (var dbContext = new PrnAssContext())
            {
                // Load customer details
                Customer = dbContext.Customers.FirstOrDefault(c => c.CustomerId == CustomerIDTest.CustomerID);
            }
        }

        private void EditCustomer(object parameter)
        {
            IsReadOnlyMode = false;
            IsEditMode = true;
        }

        private void SaveCustomerChanges(object parameter)
        {
            using (var dbContext = new PrnAssContext())
            {
                var customerInDb = dbContext.Customers.FirstOrDefault(c => c.CustomerId == Customer.CustomerId);
                if (customerInDb != null)
                {
                    bool hasError = false;
                    if (!string.IsNullOrWhiteSpace(Customer.CustomerFullName))
                    {
                        customerInDb.CustomerFullName = Customer.CustomerFullName;
                    }
                    else
                    {
                        hasError = true;
                    }
                    if (!string.IsNullOrWhiteSpace(Customer.Telephone) && Customer.Telephone.All(char.IsDigit))
                    {
                        customerInDb.Telephone = Customer.Telephone;
                    }
                    else
                    {
                        hasError = true;
                    }
                    if (!string.IsNullOrWhiteSpace(Customer.EmailAddress) && IsValidEmail(Customer.EmailAddress))
                    {
                        customerInDb.EmailAddress = Customer.EmailAddress;
                    }
                    else
                    {
                        hasError = true;
                    }
                    if (Customer.CustomerBirthday != default(DateOnly))
                    {
                        customerInDb.CustomerBirthday = Customer.CustomerBirthday;
                    }
                    else
                    {
                        hasError = true;
                    }
                    customerInDb.CustomerStatus = Customer.CustomerStatus;

                    if (!hasError)
                    {
                        dbContext.SaveChanges();
                        IsReadOnlyMode = true;
                        IsEditMode = false;
                    }
                    else
                    {
                        LoadCustomerData(null);
                    }
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
