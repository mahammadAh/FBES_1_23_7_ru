using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Note> Notes { get; set;}
    }
}
