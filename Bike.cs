using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberExam
{
    public enum Type
    {
        Racing,
        Regular,
        Electric
    }
    public class Bike
    {
        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Type TypeOfBike { get; set; }

        //methods
        public void AddVat(decimal AddedVat)
        {
            AddedVat = Price * 0.23m;
            Price = Price + AddedVat;

        }
    }

}
