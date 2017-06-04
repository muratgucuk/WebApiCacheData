using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CacheData.Models
{
    [Table("Authors")]
    public class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}