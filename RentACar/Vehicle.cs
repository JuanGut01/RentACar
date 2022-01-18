using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Vehicle
    {
        public int vehicleId;
        public string brand;
        public string model;
        public Boolean available;
        public int numTires;
        public double basePrice;
        // public abstract int maxSpeed; 


        public void rent() 
        {
         
        }
    }


    public class Car : Vehicle
    {
        public Boolean winterTires;
        public int numSeats;
        public Boolean automatic;
    }

    public class Bike : Vehicle
    {
        public int numGears;
        public Boolean eBike;
    }

    public class Motorbike : Vehicle
    {
        public Boolean winterTires;
    }
}
