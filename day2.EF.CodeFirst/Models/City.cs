using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace day2.EF.CodeFirst.Models
{
    [Table("City")]
   public class City
    {

        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int FK_CountryId { get; set; }

        [ForeignKey("FK_CountryId")]
        public Country country { get; set; }
        //public List<User> users { get; set; }
        public List<UserVist> UserVist { get; set; }
    }
}
