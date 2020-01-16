using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Nested types
Nested classes are a convenient way tp allow an outer class to create and use objects without 
Making them accessible outside the class. A nested class has access to all the members that are accessible to its
Containing type.

 */
namespace CSharpS4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            //Deck.Card card = new Deck.Card();
            deck1.dealCard();
        }
    }
}
