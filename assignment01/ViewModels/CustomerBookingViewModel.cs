using assignment01.Models;
using assignment01.Utilities;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace assignment01.ViewModels
{
    public class CustomerBookingViewModel : BaseViewModel
    {
        private ObservableCollection<Booking> _customerBookings;

        public ObservableCollection<Booking> CustomerBookings
        {
            get => _customerBookings;
            set
            {
                _customerBookings = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadCustomerBookingsCommand { get; }

        public CustomerBookingViewModel()
        {
            LoadCustomerBookingsCommand = new RelayCommand(LoadCustomerBookings);
            CustomerBookings = new ObservableCollection<Booking>();
        }

        private void LoadCustomerBookings(object parameter)
        {
            using (var dbContext = new PrnAssContext())
            {
                var bookings = dbContext.Bookings
                                        .Where(b => b.CustomerId == CustomerIDTest.CustomerID)
                                        .ToList();

                CustomerBookings.Clear();
                foreach (var booking in bookings)
                {
                    CustomerBookings.Add(booking);
                }
            }
        }
    }
}
