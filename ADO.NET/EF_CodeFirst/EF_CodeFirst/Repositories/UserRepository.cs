using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    internal class UserRepository
    {
        public NotionContext notionContext {  get; set; }

        public UserRepository()
        {
            notionContext = new NotionContext();
        }


        public void Add(User user)
        {
            notionContext.Users.Add(user);
            notionContext.SaveChanges();
        }
    }
}
