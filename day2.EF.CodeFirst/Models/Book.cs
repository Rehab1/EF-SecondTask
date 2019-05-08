using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace day2.EF.CodeFirst.Models
{
   public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public User Designer { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Designer")]
        public int DesignerId { get; set; }
    }
}
