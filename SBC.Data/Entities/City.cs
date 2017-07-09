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
    [Table("MstCity")]
    public class City : IEntity
    {
        [Required]
        public string Name { get; set; }
        public int CityCode { get; set; }
        [Required]
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        [Required]
        [ForeignKey("State")]
        public int StateID { get; set; }
        public virtual State State { get; set; }
    }
}
