using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Repositories
{
    internal class ImageRepository
    {

        public NotionContext notionContext { get; set; }

        public ImageRepository()
        {
            notionContext = new NotionContext();
        }


        public void Add(Image image)
        {
            notionContext.Images.Add(image);
            notionContext.SaveChanges();
        }
    }
}
