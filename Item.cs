using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Item
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} | Opis:  {1} | Cena: {2} PLN",
                   name, description, price);
           }
       }
    }
}
