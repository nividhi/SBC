using SBC.Data.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Data.Entities
{
    [Table("MstItem")]
    public class Item : IEntity
    {
        [Required]
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public float Gram { get; set; }
        
    }
}
