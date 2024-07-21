using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    internal class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Note> Notes { get; set;}
    }
}
