using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracking.Models;

namespace VehicleTracking.Helpers
{
    public sealed class Store
    {
        private static readonly Store instance = new Store();

        static Store()
        {

        }

        private Store()
        {
            this.Vehicles = new List<Vehicle>();
            var cust1 = new Customer { Id = 1, Name = "Amit Sinha", Address = "Borivali West", ContactNumber = "9876543210", LicenceNumber = "MH0276554325167" };
            var cust2 = new Customer { Id = 2, Name = "Aaliya Bhatt", Address = "Bandra West", ContactNumber = "6754321897", LicenceNumber = "NULME5KC09CJB8168875" };
            var owner1 = new Owner { Id = 1, Customer = cust1, StartDate = new DateTime(2019, 09, 23), EndDate = new DateTime(2020, 11, 05) };
            var owner2 = new Owner { Id = 2, Customer = cust2, StartDate = new DateTime(2020, 12, 15) };
            var owner3 = new Owner { Id = 3, Customer = cust1, StartDate = new DateTime(2021, 05, 11) };
            var veh1 = new Vehicle { Id = 1, Make = "Maruti", Model = "Swift", Color = "Red", ChasisNumber = "NULME5KC09CJB8165432", EngineNumber = "KCDF54321", RegistrationNumber = "MH02ER1234", IsFlagged = false };
            var veh2 = new Vehicle { Id = 2, Make = "Hyundai", Model = "i20", Color = "Silver", ChasisNumber = "NULME5KC09CJB8165523", EngineNumber = "HGDFG87634", RegistrationNumber = "MH04FG4321", IsFlagged = true };
            veh1.Owners.Add(owner1);
            veh1.Owners.Add(owner2);
            veh2.Owners.Add(owner3);
            var track1 = new Track { Id = 1, VehicleId = 1, Lattitude = 19.117812, Longitude = 72.829261, Date = new DateTime(2020, 05, 09) };
            var track2 = new Track { Id = 2, VehicleId = 1, Lattitude = 19.220629, Longitude = 72.840956, Date = new DateTime(2020, 07, 13) };
            var track3 = new Track { Id = 3, VehicleId = 2, Lattitude = 19.059371, Longitude = 72.831589, Date = new DateTime(2021, 02, 15) };
            var track4 = new Track { Id = 4, VehicleId = 2, Lattitude = 19.005215, Longitude = 72.817698, Date = new DateTime(2021, 04, 16) };

            veh1.Tracks.Add(track1);
            veh1.Tracks.Add(track2);
            veh2.Tracks.Add(track3);
            veh2.Tracks.Add(track4);

            this.Vehicles.Add(veh1);
            this.Vehicles.Add(veh2);
        }

        public static Store Instance
        {
            get
            {
                return instance;
            }
        }
        public List<Vehicle> Vehicles { get; set; }

    }
}
