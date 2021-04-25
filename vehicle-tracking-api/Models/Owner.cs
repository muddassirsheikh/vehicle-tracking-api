using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracking.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public Customer Customer {get; set;}

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
