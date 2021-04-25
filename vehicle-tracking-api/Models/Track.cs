using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracking.Models
{
    public class Track
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public DateTime Date { get; set; }

        public double Lattitude { get; set; }

        public double Longitude { get; set; }
    }
}
