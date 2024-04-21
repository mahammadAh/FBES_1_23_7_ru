using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace MVVMShop.Model
{
    public class Product
    {
       public Guid Id { get; set; } = Guid.NewGuid();
       public string Name { get; set; }
       public string Description { get; set; }
       public float Cost { get; set; }
       public string ImageUrl { get; set; }
    }
}
