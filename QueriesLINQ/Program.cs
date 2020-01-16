using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust1 = new { id = 1, name = "John Smith" };
            var cust2 = new { id = 2, name = "Jon Snow" };
            var cust3 = new { id = 3, name = "Adam Walker" };

            var clist = new[] { cust1, cust2, cust3 }.ToList();

            var cQuery = clist.Where(n => n.id > 1).OrderBy(n => n.name.Split().Last());

            foreach (var cust in cQuery)
                Console.WriteLine(cust.name);

            clist.Add(new { id = 4, name = "Amy Rhodes" });

            var cQuery2 =
                from cust in clist
                let last = cust.name.Split().Last()
                orderby last
                select cust;
            foreach (var cust in cQuery2)
                Console.WriteLine(cust.name);

            var ord1 = new { cid = 1, oid = 120397 };
            var ord2 = new { cid = 2, oid = 120398 };
            var ord3 = new { cid = 2, oid = 120399 };
            var ord4 = new { cid = 2, oid = 120123 };
            var ord5 = new { cid = 3, oid = 120432 };
            var ord6 = new { cid = 3, oid = 120234 };
            var ord7 = new { cid = 1, oid = 120543 };
            var ord8 = new { cid = 4, oid = 120423 };

            var orders = new[] { ord1, ord2, ord3, ord4, ord5, ord6, ord7, ord8 }.ToList();

            var iQuery =
                from cust in clist
                join ord in orders on cust.id equals ord.cid
                group cust by cust.id into grouped
                where grouped.Count() > 1
                select new { id = grouped.Key, count = grouped.Count() };

            foreach (var i in iQuery)
                Console.WriteLine("Customer id: {0}, # of orders: {1}", i.id, i.count);


        }
    }
}
