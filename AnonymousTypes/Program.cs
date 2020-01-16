using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Anonymous Types
They provide a convenient way to encapsulate a set of read only properties into a single object without to explicitly
define a type first.
var v = new { Amount = 108, Message = “Hello” }

v.Amount
v.GetType()

v.Equals()

 */
namespace CSharpS5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var card1 = new { Face = 0, Suit = "Spades" };
            var card2 = new { Face = 0, Suit = "Spades" };

            if (card1.GetType() == card2.GetType())
                Console.WriteLine("card1 and card2 have the same type");

            if (card1 == card2)
                Console.WriteLine("card1 is equal to card2");

            if (card1.Suit is string)
                Console.WriteLine("Property Suit is a string");

            //card1.Face = 12; //Error it is read only

            Console.WriteLine(card1.Face + card1.Suit);
        }
    }
}
