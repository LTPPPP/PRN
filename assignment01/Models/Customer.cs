using System;
using System.Collections.Generic;

namespace assignment01.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerFullName { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public DateOnly CustomerBirthday { get; set; }

        public int CustomerStatus { get; set; }

        public string Password { get; set; } = string.Empty;

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
