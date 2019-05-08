using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace day2.EF.CodeFirst.Models
{
    [Table("User")]
   public class User
    {
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        //public List<City> cities { get; set; }
        public List<UserVist> UserVist { get; set; }
        [InverseProperty("Author")]
        public List<Book> Authored { get; set; }

        [InverseProperty("Designer")]
        public List<Book> Designed { get; set; }

    }
}
