using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Repositories
{
    internal class IdCardRepository
    {
        public NotionContext notionContext { get; set; }

        public IdCardRepository()
        {
            notionContext = new NotionContext();
        }


        public void Add(IdCard idCard)
        {
            notionContext.IdCards.Add(idCard);
            notionContext.SaveChanges();
        }


        public List<IdCard> GetAll()
        {
            //  notionContext.Configuration.LazyLoadingEnabled = false;

            //   var users = notionContext.Users.Include("IdCard").ToList();
            var idCards = notionContext.IdCards.ToList();
            return idCards;

        }
    }
}
