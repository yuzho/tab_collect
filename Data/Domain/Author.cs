using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Avatar { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
