using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
          ShopEntities shopEntities = new ShopEntities();

            //Customer customer = new Customer();
            //customer.Id = 200;
            //customer.FirstName = "Anvar";
            //customer.LastName = "Sadiq";
            //customer.City = "Baku";
            //customer.Country = "Azerbaijan";
            //customer.Phone = "055-444-44-44";

            //shopEntities.Customers.Add(customer);

            //shopEntities.SaveChanges();



            //var selectedCustomer = shopEntities.Customers.Where(c => c.FirstName == "Anvar").FirstOrDefault();

            //selectedCustomer.Phone = "055-454-54-54";

            //shopEntities.SaveChanges();


            var selectedCustomer = shopEntities.Customers.Where(c => c.FirstName == "Anvar").FirstOrDefault();

            shopEntities.Customers.Remove(selectedCustomer);

            shopEntities.SaveChanges();



            var customers = shopEntities.Customers
                  .Where(c => c.FirstName.StartsWith("A"))
                  .Where(c => c.FirstName.Length < 6);

            Console.WriteLine(customers + "\n\n\n");

            foreach (var customer in customers)
            {

                Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Phone}");
            }

            Console.WriteLine("\n\nFinish!");
            Console.Read();
        }
    }
}
