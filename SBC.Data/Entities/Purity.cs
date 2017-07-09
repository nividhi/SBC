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
    [Table("MstPurity")]
    public class Purity : IEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public float PurityValue { get; set; }
        [Required]
        [ForeignKey("Type")]
        public int TypeID { get; set; }
        public virtual Type Type { get; set; }
    }
}
