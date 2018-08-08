using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        private static readonly List<string> Classmates = new List<string>()
        {
            "Rabin",
            "Aquoinette",
            "Chris",
            "Sean A",
            "Sean S",
            "Ross",
            "Dr. Clark",
            "Mike",
            "Catherine",
            "Bradley",
            "Jacob"
        };
        static void Main(string[] args)
        {
            RunLinkedListExample();
            Console.WriteLine("Press any key to continue to Generic Linked List example");
            Console.ReadKey();
            Console.Clear();
            RunGenericLinkedListExample();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void RunGenericLinkedListExample()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Generic Linked List Example");
            Console.WriteLine("=================================");
            var genericLinkedList = new LinkedList<string>();
            genericLinkedList.PrintAllNodes();
            foreach (var student in Classmates)
            {
                genericLinkedList.AddAtStart(student);
                Console.Write($"After adding {student}: ");
                genericLinkedList.PrintAllNodes();
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("******** Removing Classmates ***********");
            while (true)
            {
                try
                {
                    genericLinkedList.RemoveFromStart();
                    genericLinkedList.PrintAllNodes();
                }
                catch (Exception)
                {
                    genericLinkedList.PrintAllNodes();
                    break;
                }
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static void RunLinkedListExample()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Linked List Example");
            Console.WriteLine("=================================");
            var objectLinkedList = new LinkedList();
            objectLinkedList.PrintAllNodes();
            foreach (var student in Classmates)
            {
                objectLinkedList.AddAtStart(student);
                Console.Write($"After adding {student}: ");
                objectLinkedList.PrintAllNodes();
            }
            Console.WriteLine("here it is reversed");
            objectLinkedList.PrintAllNodesReverse();

            Console.WriteLine("Press any key to continue.");
            Console.WriteLine("what do you want removed?");
            string UserInput = Console.ReadLine();
            int UserIntput = int.Parse(UserInput);
            objectLinkedList.RemoveAt(UserIntput);
            
            Console.WriteLine("Cool, wanna put data in at a point? first the number:");
            string UserInputInsert = Console.ReadLine();
            int UserIntputInsert = int.Parse(UserInputInsert);
            Console.WriteLine("nice, now the data for that list object:");
            string UserInsertValue = Console.ReadLine();
            objectLinkedList.InsertAt(UserIntputInsert, UserInsertValue);
            Console.WriteLine();
            Console.WriteLine("******** Removing Classmates ***********");
            while (true)
            {
                try
                {
                    objectLinkedList.RemoveFromStart();
                    objectLinkedList.PrintAllNodes();
                }
                catch (Exception)
                {
                    objectLinkedList.PrintAllNodes();
                    
                    break;
                }
            }
            int [] TestNumbers = new int[]
                { 1,7,3,2,1,5,3,2,1,6};
            var CAResult = CountingAlgorithm.CountWithArray(TestNumbers);
            var CDResult = CountingAlgorithm.CountWithDicionary(TestNumbers);
            for (int i = 0; i < CAResult.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, CAResult[i]);
            }
            
            foreach (KeyValuePair<int, int> kvp in CDResult)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
