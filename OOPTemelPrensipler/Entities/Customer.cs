using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTemelPrensipler.Entities
{
    public class Customer
    {
        public Customer(string musteriAdi)
        {
            FirstName = musteriAdi;
        }

        public string? CustomerId { get; } = Guid.NewGuid().ToString();

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email {  get; set; }

        public string? Phone { get; set; }

        public bool IsActive { get; set; }

        public string Country { get; set; } = "Türkiye";

        public string MusteriControl()
        {
            return "";
        }
    }
}
