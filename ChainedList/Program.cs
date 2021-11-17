using System;

namespace GenericList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GenericListTest();
            LinkedListTest();
        }

        public static void LinkedListTest()
        {
            Console.WriteLine("LinkedList Tests");
            Console.WriteLine("******************************");
            // Création liste
            LinkedList<int> chainedList = new LinkedList<int>();

            // Add 5, 10, 4
            Console.WriteLine("Add 5, 10, 4");
            chainedList.Add(5);
            chainedList.Add(10);
            chainedList.Add(4);
            // Add 99 1st position
            Console.WriteLine("Add 99 1st position");
            chainedList.AddAt(99, 0);
            // Add 33 2nd position
            Console.WriteLine("Add 33 2nd position");
            chainedList.AddAt(33, 2);
            Console.WriteLine("Add 30 2nd position");
            chainedList.AddAt(30, 2);
            //Console.WriteLine("Add 50 10th position");
            //chainedList.AddAt(50, 10);
            int i = 0;
            while (i <= chainedList.Count -1)
            {
                Console.WriteLine(chainedList.GetElementByKey(i).Value);
                i++;
            }
            Console.WriteLine("***************");
            Console.WriteLine("First : " + chainedList.First.Value);
            Console.WriteLine("Last : " + chainedList.Last.Value);
            Console.WriteLine("Count : " + chainedList.Count);
            Console.WriteLine("******************************");

            Console.ReadLine();
        }

        public static void GenericListTest()
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(25);
            list.Add(30);
            list.Add(5);

            Console.WriteLine(list.GetElement(0));
            Console.WriteLine(list.GetElement(1));
            Console.WriteLine(list.GetElement(2));

            for (int i = 0; i < 30; i++)
            {
                list.Add(i);
            }

            Console.ReadLine();
        }
    }
}
