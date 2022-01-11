using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Vehicle
    {
        public int id;
        public string brand;
        public string model;
        public Boolean available;
        public int numTires;
        public double basePrice;
        public abstract int maxSpeed; 


        public void rent() { 
        }
    }
}
