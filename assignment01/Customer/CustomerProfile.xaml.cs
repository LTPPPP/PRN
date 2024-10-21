using assignment01.ViewModels;
using System.Windows.Controls;

namespace assignment01
{
    public partial class CustomerProfile : Page
    {
        public CustomerProfile()
        {
            InitializeComponent();
            var viewModel = (CustomerProfileViewModel)this.DataContext;
            viewModel.LoadCustomerCommand.Execute(null);
        }
    }
}
