using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Data.BaseEntity
{
    public abstract class IEntity
    {
        [Key]
        public int RecordID { get; set; }
        [Required]
        public Guid RawID { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
