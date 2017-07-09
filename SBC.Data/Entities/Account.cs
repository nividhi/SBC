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
    [Table("MstAccount")]
    public class Account : IEntity
    {
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        [Required]
        [ForeignKey("State")]
        public int StateID { get; set; }
        public virtual State State { get; set; }
        [Required]
        [ForeignKey("City")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
        public int PinCode { get; set; }
        [Required]
        [ForeignKey("AccountType")]
        public int AccountTypeID { get; set; }
        public virtual AccountType AccountType { get; set; }
        public string GSTIN { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
