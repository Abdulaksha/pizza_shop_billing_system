using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8
{
    class product
    {
        private string productname;

        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string pizzasize;

        public string Pizzasize
        {
            get { return pizzasize; }
            set { pizzasize = value; }
        }
        private string crusted;

        public string Crusted
        {
            get { return crusted; }
            set { crusted = value; }
        }
        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public override string ToString()
        {
            return ("STUFFED=" + productname  +"QUANTITY=" + quantity +  "PRICE" + Price +  "SIZE=" + pizzasize + "CRUSTED=" + crusted + "TOPPINGS=" + toppings + "TOTAL=" + total);
        }
    }
}
