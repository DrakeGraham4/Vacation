using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacation.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string ConfirmationNumber { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public int Cost { get; set; }
    }
}