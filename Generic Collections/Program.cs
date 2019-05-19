using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)

        {
            GroceryList();
            Console.Clear();

            ColorsLinkedList();
            Console.Clear();

            TableQueue();
            Console.Clear();

            LastRepairStack();
            Console.Clear();

            ListDictionary();
            Console.Clear();

            FruitCount();
            Console.Clear();
            
            HashsetMenWomen();
            Console.Clear();


        }

        private static void GroceryList()
        {
            Console.WriteLine("1. List");
            List<string> groceries = new List<string>() { "Apples", "Oranges", "Bananas", "Carrots", "Ice Cream" };
            foreach(var item in groceries)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void ColorsLinkedList()
        {
            Console.WriteLine("2. LinkedList");
            Console.WriteLine("LinkedList of colors");
            LinkedList<string> colorsList = new LinkedList<string>();
            foreach (string color in new string[] { "Red", "Orange", "Yellow", "Green", "Blue" })
            {
                colorsList.AddLast(color);
            }
            foreach (var color in colorsList)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
        }
        private static void TableQueue()
        {
            Console.WriteLine("3. Queue.");
            Queue<string> names = new Queue<string>();

            foreach (var name in new string [] {"Alice", "Brittany", "Catherine", "Danielle", "Emily" })
            {
                names.Enqueue(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
        private static void LastRepairStack()
        {
            Console.WriteLine("4. Stack.");
            Stack<string> repairs = new Stack<string>();

            foreach (var repair in new string[] { "Oil Change", "All Tires", "Front Brakes", "Timing Chain", "Water Pump" })
            {
                repairs.Push(repair);
            }
            foreach (var repair in repairs)
            {
                Console.WriteLine(repair);
            }
            Console.ReadLine();
        }
        private static void ListDictionary()
        {
            Console.WriteLine("5. ListDictionary.");
            Dictionary<string, int> seatNumber = new Dictionary<string, int>() { { "Adam", 1 }, { "Alice", 2 }, { "Bryan", 3 }, { "Brittany", 4 }, { "Charlie", 5 } };
            foreach (var num in seatNumber)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

        private static void FruitCount()
        {
            Console.WriteLine("6. Sorted List");
            SortedList<string, int> count = new SortedList<string, int>() { { "Apple", 3 }, { "Banana", 6 }, { "Cherry", 20 }, { "Orange", 5 }, { "Mango", 2 } };

            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void HashsetMenWomen()
        {
            Console.WriteLine("7. HashSet.");
            HashSet<string> men = new HashSet<string>() { "Adam", "Bryan", "Charlie", "David", "Eddie" };

            HashSet<string> women = new HashSet<string>() { "Alice", "Brittany", "Catherine", "Danielle", "Emily" };

            men.UnionWith(women);

            foreach (var person in men)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}




