using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace day2.EF.CodeFirst.Models
{
    [Table("Country")]
   public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }
        public List<City> cites{ get; set; }
    }
}
