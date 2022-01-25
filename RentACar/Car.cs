using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Car : Vehicle
    {
        public bool winterTires;
        public int numSeats;
        public bool automatic;
        
        public Car(int id, string brand, string model, bool available, int numtires, double baseprice, int maxspeed, bool wintertires, int numseats, bool auto)
        {
            this.vehicleId = id;
            this.brand = brand;
            this.model = model;
            this.available = available;
            this.numTires = numtires;
            this.basePrice = baseprice;
            this.winterTires = wintertires;
            this.numSeats = numseats;
            this.automatic = auto;
            this.maxSpeed = maxspeed;
        }
    }
}
