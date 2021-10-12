using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime Orderdate { get; set; }

        public Item Item { get; set; }
        public Item UnitPrice { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
