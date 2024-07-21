using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Repositories
{
    internal class NoteRepository
    {

        public NotionContext notionContext { get; set; }

        public NoteRepository()
        {
            notionContext = new NotionContext();
        }


        public void Add(Note note)
        {
            notionContext.Notes.Add(note);
            notionContext.SaveChanges();
        }
    }
}
