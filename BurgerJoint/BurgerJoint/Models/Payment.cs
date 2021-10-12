using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint.Models
{
    public class Payment
    {
        [ForeignKey("Order")]
        public int PaymentId { get; set; }
        public int Subtotal { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Paydate { get; set; }

        public virtual Order Order { get; set; }
    }
}
