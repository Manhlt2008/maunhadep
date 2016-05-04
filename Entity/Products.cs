using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ProductAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public double SaleOffPrice { get; set; }
        public string Address { get; set; }

    }
}
