using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public class NotionContext : DbContext
    {

        public NotionContext() : base("LocalNotionDb")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<IdCard> IdCards { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<NotesImages> NotesImages { get; set; }
    }
}
