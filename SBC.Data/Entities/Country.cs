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
    [Table("MstCountry")]
    public class Country : IEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
