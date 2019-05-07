using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Restaurant
    {
        public string name { get; set; }
        public string typeOfkitchen { get; set; }
        public double costOfdelivery { get; set; }
        public int averageTime { get; set; }

        public List<Item> Itemy { get; set; }

        
        public string Display
        {
            get
            {
                return string.Format("{0} | Kuchnia {1} | Koszt dostawy: {2} PLN | Sredni czas dostawy {3} minut |",
                    name, typeOfkitchen, costOfdelivery, averageTime);
            } 
        }
    }
}
