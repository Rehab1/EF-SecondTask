using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace day2.EF.CodeFirst.Models
{
    [Table("UserVist")]
    public class UserVist
    {
        public DateTime when { get; set; }
        //public int CityId { get; set; }
     
        [Key]
        [ForeignKey("user")]
        [Column(Order =1)]
        public int FK_UserId { get; set; }

        [Key]
        [ForeignKey("City")]
        [Column(Order = 2)]
        public int FK_CityId { get; set; }

        public User user { get; set; }
        public City City { get; set; }


    }
}
