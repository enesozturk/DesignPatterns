using Iterator.Aggregate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyp = new NYPaper();
            INewspaper lap = new LAPaper();

            IIterator nypIterator = nyp.CreateIterator();
            IIterator lapIterator = lap.CreateIterator();

            Console.WriteLine("-----    NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("-----    LAPaper");
            PrintReporters(lapIterator);
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.isDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
