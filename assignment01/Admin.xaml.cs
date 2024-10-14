using System;
using System.Windows;
using System.Windows.Controls;

namespace assignment01
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            AdminPage.Content = new CustomerManagement();
        }

        private void RoomManagement_Click(object sender, RoutedEventArgs e)
        {
            AdminPage.Content = new RoomManagement();
        }

        private void BookingManagement_Click(object sender, RoutedEventArgs e)
        {
            AdminPage.Content = new BookingManagement();
        }
    }

}
