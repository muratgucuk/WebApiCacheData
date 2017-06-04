using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CacheData.Models
{
    [Table("Books")]
    public class Books
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ISBN { get; set; }

        public int Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public virtual Authors Author { get; set; }
    }
}