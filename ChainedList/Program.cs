using System;

namespace ChainedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChainedList Tests");

            // Création liste
            ChainedList<int> chainedList = new ChainedList<int>(10);

            // Ajout 5, 10, 4
            chainedList.Add(5, 10, 4);

            // Afficher
            Console.WriteLine("Nb element : " + chainedList.ElementCount);
            Console.WriteLine("Size table : " + chainedList.tableSize);

            Console.WriteLine("first : " + chainedList.FirstElement.Value);
            Console.WriteLine("last : " + chainedList.LastElement);

            Console.WriteLine("***************");

            // Add 99 1st position
            chainedList.AddAt(99, 0);

            for (int i=0; i < chainedList.ElementCount; i++)
            {
                Console.WriteLine(chainedList.GetElementByKey(i));
            }
            Console.WriteLine("***************");

            // Add 33 2nd position
            chainedList.AddAt(33, 1);

            Console.WriteLine(chainedList.GetElementByKey(0));
            Console.WriteLine(chainedList.GetElementByKey(1));
            Console.WriteLine(chainedList.GetElementByKey(2));
            Console.WriteLine(chainedList.GetElementByKey(3));
            Console.WriteLine(chainedList.GetElementByKey(4));
            Console.WriteLine("***************");

            Console.ReadLine();
        }
    }
}
