using AlDar_1._0.Common_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlDar_1._0.Models
{
    public class Valuations
    {
        public Valuations()
        {
            this.Productes = new HashSet<Products>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVal { get; set; }
        public string NameVal { get; set; }
        public float ValTotalAmount { get; set; }
        public DateTime AddDate { get; set; }       
        public ValStatus Status { get; set; }
        public virtual ICollection<Products> Productes { get; set; }
    }
}
