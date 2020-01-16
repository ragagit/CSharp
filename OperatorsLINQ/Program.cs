using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Most of the LINQ methods operate on sequences where a sequence is an object whose type implements the
IEnumerable<T> interface or the IQueryable<T> interface.

Sorting
    OrderBy

    OrderByDescending
    ThenBy

    ThenByDescending
    Reverse

Set Operations

    Distinct
    Except

    Intersect
    Union

Filtering
    OfType

    where

Quantifiers

    All
    Any

    Contains

Projections

    select
    selectMany

Partitioning
    Skip

    SkipWhile
    Take

    TakeWhile

Join

Generation
    DefaultEmpty
    Empty
    Range
    Repeat

Equality
    SequenceEqual

Elements
    ElementAt
    ElementAtOrDefault
    First
    FirstDefault

Concatenation
    Concat

Aggregation
    Aggregate
    Average
    Count
    LongCount
    Max
    Min
    Sum



*/
namespace CSharpS6_3
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                return Name.Equals(((Person) obj).Name);
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }
        }
        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }
        static void Main(string[] args)
        {
            Person jeff = new Person { Name = "Jeff" };
            Person steve = new Person { Name = "Steve" };
            Person ally = new Person { Name = "Ally" };
            Person ally2 = new Person { Name = "Ally" };

            Pet spot = new Pet { Name = "Spot", Owner = steve };
            Pet fido = new Pet { Name = "Fido", Owner = steve };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = jeff };

            List<Person> people = new List<Person>();

            people.Add(jeff);
            people.Add(steve);
            people.Add(ally);
            people.Add(ally2);

            List<Pet> pets = new List<Pet>();

            pets.Add(spot);
            pets.Add(fido);
            pets.Add(whiskers);

            IEnumerable<Person> pQuery =
                from per in people
                orderby per.Name descending
                select per;

            foreach (Person p in pQuery)
                Console.WriteLine(p.Name);

            var joinQuery =
                people.Join(
                pets,
                person => person,
                pet => pet.Owner,
                (pet, person) => new { OwnerName = person.Name, PetName = pet.Name});
            Console.WriteLine("Join Operation");
            foreach (var po in joinQuery)
                Console.WriteLine("Pet: {0} Owner: {1}", po.PetName, po.OwnerName);

            IEnumerable<IGrouping<string, string>> groupQuery =
                pets.GroupBy(pet => pet.Owner.Name, pet => pet.Name);

            foreach(IGrouping<string, string> group in groupQuery){
                Console.WriteLine(group.Key);

                foreach (string pet in group)
                    Console.WriteLine("   {0}", pet);
            }

            Console.WriteLine("Count of pets: {0}", pets.Count());

            int[] numbers = { 9, 68, 23, 67, 99, 192, 33, 66 };
            
            Console.WriteLine("Average of numbers: {0}", numbers.Average());
            Console.WriteLine("Sum of numbers: {0}", numbers.Sum());
            Console.WriteLine("Max of numbers: {0}", numbers.Max());
        }
    }
}
