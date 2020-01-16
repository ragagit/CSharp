using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Structs are light versions of classes. Structs are value types and can be used to create objects that behave like built-in types.

Structs share many features with classes but with the following limitations as compared to classes.

Struct cannot have a default constructor (a constructor without parameters) or a destructor.
Structs are value types and are copied on assignment. 
Structs are value types while classes are reference types.
Structs can be instantiated without using a new operator.
A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly from System.ValueType, which inherits from System.Object.
Struct cannot be a base class. So, Struct types cannot abstract and are always implicitly sealed.
Abstract and sealed modifiers are not allowed and struct member cannot be protected or protected internals.
Function members in a struct cannot be abstract or virtual, and the override modifier is allowed only to the override methods inherited from System.ValueType.
Struct does not allow the instance field declarations to include variable initializers. But, static fields of a struct are allowed to include variable initializers.
A struct can implement interfaces.
A struct can be used as a nullable type and can be assigned a null value.
When to use struct or classes?
 
To answer this question, we should have a good understanding of the differences.

 S.N	 Struct	 Classes
 1	 Structs are value types, allocated either on the stack or inline in containing types.	Classes are reference types, allocated on the heap and garbage-collected. 
 2 	 Allocations and de-allocations of value types are in general cheaper than allocations and de-allocations of reference types.	 Assignments of large reference types are cheaper than assignments of large value types.
 3	In structs, each variable contains its own copy of the data (except in the case of the ref and out parameter variables), and an operation on one variable does not affect another variable.
 In classes, two variables can contain the reference of the same object and any operation on one variable can affect another variable.
 */
namespace CSharpS2_2
{
    class Program
    {
        public struct Book
        {
            public decimal price;
            public string author;
            public string title;

            public Book(decimal d, string a, string t)
            {
                price = d;
                author = a;
                title = t;
            }
        }
        static void Main(string[] args)
        {
            int[] iarray = new int[6];

            iarray[0] = 10;

            Console.WriteLine(iarray[0]);

            int[] iarray2 = { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(",", iarray2));

            Book book1;

            book1.price = 5.00m;

            Console.WriteLine(book1.price);

            Book book2 = new Book(10.00m, "George Orwell", "1984");

            Console.WriteLine(book2.price + ", " + book2.author);
        }
    }
}
//if, switch, do, for, foreach, in, while, do while
//foreach(int i in iarray)
//break, continue, goto, return, throw
//methods, overloading
//casting (int)