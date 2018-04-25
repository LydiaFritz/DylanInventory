using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4
{
    class Product
    {
        public string Name { set; get; }
        public string Producer { set; get; }
        public double ReleaseDate { set; get; }
        public string CountryOfOrigin { set; get; }
        public double ReleasePrice { set; get; }
        public double NumberInStock { set; get; }

        public Product() { }

        //add ounces to current ounces in stock
        public void recieveStock(double total)
        {
            this.NumberInStock += total;
        }

        public bool sell(double total)
        {
            //make sure we have enough
            if(this.NumberInStock >= total)
            {
                //if so, reduce OzInStock
                this.NumberInStock -= total;
                //return true
                return true;
            }
            else
            {
                //not enough stock
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product itm = (Product)obj;

                if (itm.Name == this.Name &&
                itm.Producer == this.Name &&
                itm.ReleaseDate == this.ReleaseDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString()
        {
            return Name + " " + "\n" + Producer + " " + "\n" + ReleaseDate + " " + "\n" + CountryOfOrigin + " " + "\n" + ReleasePrice + " " + "\n" + NumberInStock;
            
        }

       
    }
}
