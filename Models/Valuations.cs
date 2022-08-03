using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Status = AlDar_1._0.Common_Class.Status;

namespace AlDar_1._0.Models
{
    internal class Valuations
    {
        public int IdVal { get; set; }
        public string NameVal { get; set; }
        public float ValTotalAmount { get; set; }
        public DateTime AddDate { get; set; }
        public virtual List<Products> Products { get; set; }
        public Status Status { get; set; }
    }
}
