using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

/*
Dynamic Binding
Visual C# 2010 introduces a new type, dynamic. The type is a static type, but an object of type dynamic bypass static type checking.
It is useful when at compile time you know that a certain function, member or operation exists but the compiler does not. If the code
Is not valid errors are caught at run time.
Custom binding occurs when a dynamic object implements IDynamicMetaObjectProvider (IDMOP).
Language Binding
Language binding is a form of dynamic binding which occurs when a dynamic object does not implement IDynamicMetaObjectProvider.


Reflection
Reflection is when managed code can read its own metadata to find assemblies. Reflection is needed when you want to determine / inspect contents of an assembly.
With reflection in C#, you can dynamically create an instance of a type and bind that type to an existing object. Moreover, you can get the type from an existing object and access its properties. 

* Both Reflection and dynamic are used when we want to operate on an object during runtime.
* Reflection is used to inspect the meta-data of an object. It also has the ability to invoke members of an object at runtime.
* dynamic is a keyword which was introduced in .NET 4.0. It evaluates object calls during runtime. So until the method calls are made the compiler is least bothered if those methods / properties exist or not.
* dynamic uses Reflection internally. It caches the method calls made thus improving performance to a certain extent.
* Reflection can invoke both public and private members of an object while dynamic can only invoke public members.
* dynamic is instance specific: you don't have access to static members; you have to use Reflection in those scenarios.

Var vs Dynamic
Var says . “Let the compiler figure out the type”
Dynamic says, “Let the runtime figure out the type”
 */
 
namespace CSharpS5_7
{
    class DynamicObj : DynamicObject
    {
        public void method1()
        {
            Console.WriteLine("This is method1");
        }
        public void writeInt(int x)
        {
            Console.WriteLine("This is the integer given: {0}", x);
        }
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine("Method {0}", binder.Name);
            result = null;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d1 = new DynamicObj();

            d1.method1();

            DynamicObj d2 = new DynamicObj();

            dynamic x = 5;
            dynamic y = "5";

            d2.writeInt(x);
            //d2.writeInt(y);

            d1.unknown();
        }
    }
}
