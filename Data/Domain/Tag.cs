using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
