using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    internal class NotesImages
    {
        public int Id { get; set; }
        public int NoteId { get; set; }

        [ForeignKey("NoteId")]
        public Note Note { get; set; }

        public int ImageId { get; set; }

        [ForeignKey("ImageId")]
        public Image Image { get; set; }
    }
}
