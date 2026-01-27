using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_demo_2
{
    abstract class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public abstract void DisplayProductDetails();

        void displayproductdetails()
        {
            Console.WriteLine("product name:" + ProductName);
        }
    }
}
