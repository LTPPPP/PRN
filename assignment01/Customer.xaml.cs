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
using System.Windows.Shapes;

namespace assignment01
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
            
        }

        public int CustomerId { get; internal set; }
        public string CustomerFullName { get; internal set; }
        public string Telephone { get; internal set; }
        public string EmailAddress { get; internal set; }
        public DateOnly CustomerBirthday { get; internal set; }
        public int CustomerStatus { get; internal set; }
        public string Password { get; internal set; }
    }
}
