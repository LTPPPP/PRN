using assignment01.Utilities;
using assignment01.ViewModels;
using System.Windows;

namespace assignment01
{
    /// <summary>
    /// Interaction logic for CustomerHomePage.xaml
    /// </summary>
    public partial class CustomerHomePage : Window
    {
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            var customerProfilePage = new CustomerProfile();
            var viewModel = new CustomerProfileViewModel();
            viewModel.LoadCustomerCommand.Execute(null);
            customerProfilePage.DataContext = viewModel;
            CustomerPage.Content = customerProfilePage;
        }

        private void CustomerBooking_Click(object sender, RoutedEventArgs e)
        {
            var customerBookingPage = new CustomerBooking();
            var viewModel = new CustomerBookingViewModel();
            viewModel.LoadCustomerBookingsCommand.Execute(null); 
            customerBookingPage.DataContext = viewModel;
            CustomerPage.Content = customerBookingPage;
        }
    }
}
