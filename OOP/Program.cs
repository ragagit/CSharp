using System;
/*
Type of constructors:
Instance
    Called when creating an object
Static
    Only one per class. Usually to init static variables
    Can't be called directly, called on the creation of the first object.
    It doesn't take any parameters.
Private
    It is used in classes that contain static members only and
    can be called only by inner classes

Accessor Modifiers
    public
    private
    internal Defualt within the same assembly
    protected derived classes have access

Inheritance
    class A {

    }
    class B : A {

    }

    public abstract class A {
        void DoWork(int i)
    }

    Sealed classes Are like final classes in Java
    it prevents them from deriveing.

    as:
        It is like a cast operation. It returns null if the operation fails.

    is:
        Evaluates to true if the provided expression is non-null and the object can
        be cast to the provided type without causing an exception to be thrown.
 */
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Card aceSpades = new Card("Ace", "Spades");

            Console.WriteLine(Card.createdAt);
            Console.WriteLine(aceSpades.Face);
            Console.ReadLine();

            Card aceClubs = new Card("Ace", "Clubs");
            aceClubs.Face="Trevor";
            Console.WriteLine(Card.createdAt);
            Console.WriteLine(aceClubs.Face);
            Console.ReadLine();
        }
    }
    class Card
    {
        public static int size;
        public static DateTime createdAt;
        string face;
        string suit;

        public Card(string f, string s)
        {
            face = f;
            suit = s;
        }

        public string Face
        {
            get { return face; }
            set { face = value; }
        }

        static Card()
        {
            size = 52;
            createdAt = DateTime.Now;
        }
    }
}
