using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacNuget.Warehouse.Events
{
    public class ProductUpdateForEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
    }

    public class NewUpdateProductEvent
    {
        public ProductUpdateForEvent Product { get; set; }
    }
}
