using assignment01.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace assignment01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            Console.WriteLine(email);
            Console.WriteLine(password);
            if (email == "admin" && password == "123")
            {
                Admin HomeAdmin = new Admin(); 
                HomeAdmin.Show();
                this.Close();
            }
            else
            {
                if (ValidateCustomerLogin(email, password))
                {
                    CustomerHomePage customerHomePage = new CustomerHomePage();
                    customerHomePage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
        }

        private bool ValidateCustomerLogin(string EmailAddress, string password)
        {
            using (var db = new PrnAssContext()) 
            {
                var customer = db.Customers
                    .FirstOrDefault(c => c.EmailAddress == EmailAddress && c.Password == password);

                return customer != null;
            }
        }
    }
}
