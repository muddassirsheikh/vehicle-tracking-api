using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracking.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.Owners = new List<Owner>();
            this.Tracks = new List<Track>();
        }
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string ChasisNumber { get; set; }

        public string EngineNumber { get; set; }

        public string RegistrationNumber { get; set; }

        public string Color { get; set; }

        public bool IsFlagged { get; set; }

        public List<Owner> Owners { get; set; }

        public List<Track> Tracks { get; set; }
    }
}
