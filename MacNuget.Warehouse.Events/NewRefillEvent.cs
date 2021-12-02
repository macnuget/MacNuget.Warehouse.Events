using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacNuget.Warehouse.Events
{
    public class ProductForRefillEvent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }
    public class NewRefillEvent
    {
        public ProductForRefillEvent Product { get; set; }
    }
}
