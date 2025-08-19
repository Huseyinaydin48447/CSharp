using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitim301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDescription { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }//1 
        public List<Order>orders { get; set; }
    }
}
