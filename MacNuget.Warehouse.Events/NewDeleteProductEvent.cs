using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacNuget.Warehouse.Events
{
    public class ProductForDeleteEvent
    {
        public int Id { get; set; }
        public bool Available { get; set; }
    }
    public class NewDeleteProductEvent
    {
        public ProductForDeleteEvent Product { get; set; }
    }
}
