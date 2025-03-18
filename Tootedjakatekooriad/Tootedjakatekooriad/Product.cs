using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tootedjakatekooriad
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
