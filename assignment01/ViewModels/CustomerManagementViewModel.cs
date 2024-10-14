using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace assignment01.ViewModels
{
    internal class CustomerManagementViewModel : BaseViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public ICommand AddCustomerCommand { get; set; }
        public ICommand UpdateCustomerCommand { get; set; }
        public ICommand DeleteCustomerCommand { get; set; }

        public CustomerManagementViewModel()
        {
            LoadCustomers();

            // Bind commands to methods
            AddCustomerCommand = new RelayCommand(AddCustomer);
            UpdateCustomerCommand = new RelayCommand(UpdateCustomer);
            DeleteCustomerCommand = new RelayCommand(RemoveCustomer);
        }

        // Load data
        private void LoadCustomers()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    CustomerFullName = "John Doe",
                    Telephone = "123-456-7890",
                    EmailAddress = "johndoe@example.com",
                    CustomerBirthday = new DateOnly(1990, 1, 1),
                    CustomerStatus = 1,
                    Password = "password123"
                }
            };
        }

        private Customer selectCustomer;
        public Customer SelectedCustomer
        {
            get => selectCustomer;
            set
            {
                selectCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }

        }

        private void AddCustomer()
        {
            int newCustomerId = Customers.Max(c => c.CustomerId) + 1;

            Customers.Add(new Customer
            {
                CustomerId = newCustomerId,
                CustomerFullName = "New Customer",
                Telephone = "000-000-0000",
                EmailAddress = "newcustomer@example.com",
                CustomerBirthday = new DateOnly(2000, 1, 1),
                CustomerStatus = 1,
                Password = HashPassword("defaultPassword") // Consider using a hashed password
            });
        }

        private void UpdateCustomer()
        {
            // Update customer logic here
        }

        // Hàm xóa
        private void RemoveCustomer(object parameter)
        {
            if (selectCustomer != null) // Kiểm tra nếu có người dùng được chọn
            {
                MessageBoxResult result = MessageBox.Show($"Bạn có chắc muốn xóa người dùng {SelectedCustomer.Name}?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButton.YesNo,
                                                          MessageBoxImage.Question);

                // Kiểm tra phản hồi của người dùng
                if (result == MessageBoxResult.Yes)
                {
                    // Tìm đối tượng trong ObservableCollection với Id tương ứng
                    var user_Del = Customers.FirstOrDefault(s => s.CustomerId == SelectedCustomer.CustomerId);
                    if (user_Del != null)
                    {
                        // Xóa đối tượng khỏi ObservableCollection
                        Customers.Remove(user_Del);
                    }
                }
                // Clear selectedUser
                SelectedCustomer = null;
            }
        }


        private string HashPassword(string password)
        {
            // Replace this with actual hashing logic (e.g., SHA256 or bcrypt)
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}
