using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberExam
{
    public enum BikeType
    {
        Racing,
        Regular,
        Electric
    }
    public class Bike
    {
        //properties
        public int BikeID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public BikeType TypeOfBike { get; set; }

        //methods
        public void AddVat(decimal AddedVat)
        {
            AddedVat = Price * 0.23m;
            Price = Price + AddedVat;

        }
        public override string ToString()
        {
            return Name + Price;
        }

        public string GetDescription()
        {
            return
                  $"Price{Price: C}\n" +
                    $"Bike Descripton: {Description}\n"
                    ;

        }

    }
     public class BikeData : DbContext
    {
        public BikeData() : base("mybikedata") { }

        public DbSet<Bike> Bikes { get; set; }
    }
}
