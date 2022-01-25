using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentACar
{
    class Offer
    {
        public int id;
        public string ownerEmail;
        public double price;
        public DateTime startDate;
        public DateTime endDate;
        public string vehicleBrand;

        public Offer(int id, string ownerEmail, double price, DateTime startdate, DateTime enddate, string vehiclebrand)
        {
            this.id = id;
            this.ownerEmail = ownerEmail;
            this.price = price;
            this.startDate = startdate;
            this.endDate = enddate;
            this.vehicleBrand = vehiclebrand;
        }

        public void accept(int id)
        {

        }

        public void decline(int id)
        {

        }

    }
}
