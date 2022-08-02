using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Status = AlDar_1._0.Common_Class.Status;

namespace AlDar_1._0.Models
{
    internal class Products
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public float DefaultPrice { get; set; }
        public int DefaultQuantity { get; set; }
        public Status Status { get; set; }
        
    }
    
}
