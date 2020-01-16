using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Customer cust1 = new Customer { Id = 1, Name = "Jon Snow"};
            Customer cust2 = new Customer { Id = 2, Name = "John Adams" };

            db.Customers.InsertOnSubmit(cust1);
            db.Customers.InsertOnSubmit(cust2);
            db.SubmitChanges();

            var custQuery =
                from cust in db.Customers
                select cust;

            foreach (Customer c in custQuery)
                Console.WriteLine(c.Name);

            Customer custUpdate = custQuery.Where(cust => cust.Id == 2).First();

            custUpdate.Name = "John Stevens";

            db.SubmitChanges();

            foreach (Customer c in custQuery)
                Console.WriteLine("Customer: {0} ID: {1}",c.Name, c.Id);

        }
    }
}
