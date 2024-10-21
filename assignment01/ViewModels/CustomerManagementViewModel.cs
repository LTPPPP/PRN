using assignment01.Models;
using assignment01.Utilities;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Text;

namespace assignment01.ViewModels
{
    public class CustomerManagementViewModel : BaseViewModel
    {
        private ObservableCollection<Customer> _customers;
        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }

        private int _customerId;
        public int CustomerId
        {
            get => _customerId;
            set
            {
                _customerId = value;
                OnPropertyChanged(nameof(CustomerId));
            }
        }
        private string _customerFullName;
        public string CustomerFullName
        {
            get => _customerFullName;
            set
            {
                _customerFullName = value;
                OnPropertyChanged(nameof(CustomerFullName));
            }
        }

        private string _telephone;
        public string Telephone
        {
            get => _telephone;
            set
            {
                _telephone = value;
                OnPropertyChanged(nameof(Telephone));
            }
        }

        private string _emailAddress;
        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                _emailAddress = value;
                OnPropertyChanged(nameof(EmailAddress));
            }
        }

        private DateOnly _customerBirthday;
        public DateOnly CustomerBirthday
        {
            get => _customerBirthday;
            set
            {
                _customerBirthday = value;
                OnPropertyChanged(nameof(CustomerBirthday));
            }
        }

        private int _customerStatus;
        public int CustomerStatus
        {
            get => _customerStatus;
            set
            {
                _customerStatus = value;
                OnPropertyChanged(nameof(CustomerStatus));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));

                if (_selectedCustomer != null)
                {
                    CustomerId = _selectedCustomer.CustomerId;
                    CustomerFullName = _selectedCustomer.CustomerFullName;
                    Telephone = _selectedCustomer.Telephone;
                    EmailAddress = _selectedCustomer.EmailAddress;
                    CustomerBirthday = _selectedCustomer.CustomerBirthday;
                    CustomerStatus = _selectedCustomer.CustomerStatus;
                    Password = _selectedCustomer.Password;
                }
            }
        }

        // Commands
        public ICommand AddCustomerCommand { get; set; }
        public ICommand UpdateCustomerCommand { get; set; }
        public ICommand DeleteCustomerCommand { get; set; }

        public CustomerManagementViewModel()
        {
            // Initialize the commands
            AddCustomerCommand = new RelayCommand(AddCustomer);
            UpdateCustomerCommand = new RelayCommand(UpdateCustomer);
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            Customers = new ObservableCollection<Customer>();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var context = new PrnAssContext())
            {
                var customerList = context.Customers.ToList();
                Customers = new ObservableCollection<Customer>(customerList);
            }
        }

        private void AddCustomer(object parameter)
        {
            try
            {
                using (var context = new PrnAssContext())
                {
                    // Find the highest CustomerId and add 1
                    int newCustomerId = context.Customers.Any() ? context.Customers.Max(c => c.CustomerId) + 1 : 1;

                    var newCustomer = new Customer
                    {
                        CustomerId = newCustomerId,  // Set the new CustomerId
                        CustomerFullName = CustomerFullName,
                        Telephone = Telephone,
                        EmailAddress = EmailAddress,
                        CustomerBirthday = CustomerBirthday,
                        CustomerStatus = 1, // Default to Active status
                        Password = HashPassword(Password)
                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                    Customers.Add(newCustomer);

                    // Reset the form
                    CustomerFullName = string.Empty;
                    Telephone = string.Empty;
                    EmailAddress = string.Empty;
                    CustomerBirthday = default;
                    CustomerStatus = 1; // Default to Active
                    Password = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the customer: {ex.Message}");
            }
        }

        private void UpdateCustomer(object parameter)
        {
            try
            {
                if (SelectedCustomer != null)
                {
                    using (var context = new PrnAssContext())
                    {
                        var customer = context.Customers.FirstOrDefault(c => c.CustomerId == SelectedCustomer.CustomerId);
                        if (customer != null)
                        {
                            customer.CustomerFullName = CustomerFullName;
                            customer.Telephone = Telephone;
                            customer.EmailAddress = EmailAddress;
                            customer.CustomerBirthday = CustomerBirthday;
                            customer.CustomerStatus = CustomerStatus;
                            if (!string.IsNullOrWhiteSpace(Password))
                            {
                                customer.Password = HashPassword(Password);
                            }

                            context.SaveChanges();
                            LoadCustomers();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the customer: {ex.Message}");
            }
        }

        private void DeleteCustomer(object parameter)
        {
            if (!string.IsNullOrEmpty(CustomerFullName)) // You can modify to use ID
            {
                using (var context = new PrnAssContext())
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerFullName == CustomerFullName);
                    if (customer != null)
                    {
                        context.Customers.Remove(customer);
                        context.SaveChanges();
                        Customers.Remove(customer);
                        LoadCustomers();
                    }
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
