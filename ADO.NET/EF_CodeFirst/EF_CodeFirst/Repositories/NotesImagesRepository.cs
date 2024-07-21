using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Repositories
{
    internal class NotesImagesRepository
    {

        public NotionContext notionContext { get; set; }

        public NotesImagesRepository()
        {
            notionContext = new NotionContext();
        }


        public void Add(NotesImages notesImages)
        {
            notionContext.NotesImages.Add(notesImages);
            notionContext.SaveChanges();
        }
    }
}
