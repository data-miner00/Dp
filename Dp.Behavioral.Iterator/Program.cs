namespace Dp.Behavioral.Iterator;

internal static class Program
{
    public static void Main(string[] args)
    {
        var peopleCollection = new PeopleCollection
        {
            new Person { Name = "Broque", Age = 25 },
            new Person { Name = "Doughlas", Age = 05 },
            new Person { Name = "Candice", Age = 15 },
            new Person { Name = "Angel", Age = 35 },
        };

        var iterator = peopleCollection.CreateIterator();

        for (var person = iterator.First(); !iterator.IsDone; person = iterator.Next())
        {
            Console.WriteLine(person?.Name);
        }
    }
}
