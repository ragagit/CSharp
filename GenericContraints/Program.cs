using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DBList<Employee> list = new DBList<Employee>();

            list.add(new Employee());
            list.add(new Employee());
            list.add(new Employee());
            list.add(new Employee());

            list.list();

            DBList<Inventory> list2 = new DBList<Inventory>();
            list2.add(new Inventory());
            list2.add(new Inventory());
            list2.add(new Inventory());
            list2.add(new Inventory());
            //list2.add(new Employee());

            list2.list();

            int[] arr = { 0, 1, 2, 3 };
            List<int> arr2 = new List<int>();

            arr2.Add(4);
            arr2.Add(5);
            arr2.Add(6);
            arr2.Add(7);

            printInts(arr);
            printInts(arr2);
        }
        static void printInts<T>(IList<T> col1)
        {
            foreach(T t in col1){
                Console.WriteLine(t);
            }
        }
    }

    interface DBItem
    {
        void display();
    }

    class DBList<T> where T : DBItem
    {
        Node head = null;
        Node tail = null;
        class Node
        {
            public T data;
            public Node next;
            public Node(T t)
            {
                data = t;
            }
        }

        public void add(T t)
        {
            if (head == null)
            {
                head = new Node(t);
                tail = head;
            }
            else
            {
                tail.next = new Node(t);
                tail = tail.next;
            }
        }

        public void list()
        {
            Node curr = head;
            while (curr != null)
            {
                curr.data.display();
                curr = curr.next;
            }
        }
    }

    class Inventory : DBItem
    {
        public void display()
        {
            Console.WriteLine("Inventory");
        }
    }

    class Employee : DBItem
    {
        public void display()
        {
            Console.WriteLine("Employee");
        }
    }
}
