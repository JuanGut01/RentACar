using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class InventoryService
    {
        public static List<Vehicle> vehicleArray = new List<Vehicle>();
        int idIndex;
        int genId()
        {
            idIndex++;
            return idIndex;
        }

        public void addVehicle(string brand, string model, Boolean available, int numTires, double basePrice, int maxSpeed) 
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vehicleId = genId();
            vehicle.brand = brand;
            vehicle.model = model;
            vehicle.available = available;
            vehicle.numTires = numTires;
            vehicle.basePrice = basePrice;
            vehicle.maxSpeed = maxSpeed;
            //vehicle.Add(vehicle);

        }
        public void deleteVehicle(int vehicleId)
        {
            foreach (Vehicle v in vehicleArray)
            {
                if(v.vehicleId == vehicleId)
                {
                    bool result = vehicleArray.Remove(v);
                }
                 
            } 


        }
        public void returnVehicle( int vehicleId)
        {

        }
    }
}
