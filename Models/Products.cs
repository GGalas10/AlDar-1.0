using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common = AlDar_1._0.Common_Class;

namespace AlDar_1._0.Models
{
    public class Products
    {
        public Products()
        {
            this.Valuationes = new HashSet<Valuations>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public float DefaultPrice { get; set; }
        public int DefaultQuantity { get; set; }
        public Common.Status Status { get; set; }
        public Common.UMeasure Measure { get; set; }

        public virtual ICollection<Valuations> Valuationes { get; set; }
        public static bool Equals(Products first,Products second)
        {
            if (first.Name == second.Name && first.Measure == second.Measure && first.Status == second.Status)
                return true;
            else
                return false;
        }

    }    
}
