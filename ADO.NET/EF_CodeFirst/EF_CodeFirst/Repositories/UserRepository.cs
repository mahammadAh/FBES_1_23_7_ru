using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public List<User> GetAll()
        {
            //  notionContext.Configuration.LazyLoadingEnabled = false;

             //var users = notionContext.Users.Include("IdCard").ToList();
             var users = notionContext.Users.AsNoTracking().ToList();
            return users;

        }
    }
}
