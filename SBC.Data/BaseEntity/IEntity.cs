using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Data.BaseEntity
{
    public class IEntity
    {
        [Key]
        public int RecordID { get; set; }
        [Required]
        public Guid RawID { get; set; }
    }
}
