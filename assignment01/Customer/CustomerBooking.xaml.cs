using assignment01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assignment01
{
    /// <summary>
    /// Interaction logic for CustomerBooking.xaml
    /// </summary>
    public partial class CustomerBooking : Page
    {
        public CustomerBooking()
        {
            InitializeComponent();
            this.DataContext = new CustomerProfileViewModel();
        }
    }
}
