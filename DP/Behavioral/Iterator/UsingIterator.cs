using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Iterator
{
    public class UsingIterator
    {
        public static void Run()
        {
            // Initialize iterable object
            var tree = new ComplexObject
            {
                Items = new List<string>
            {
                "first -> 1",
                "first -> 2",
                "first -> 3",
                "first -> 4"
            },
                Child = new ComplexObject
                {
                    Items = new List<string>
                {
                    "second -> 1",
                    "second -> 2",
                    "second -> 3",
                    "second -> 4",
                    "second -> 5",
                },
                    Child = new ComplexObject
                    {
                        Items = new List<string>
                        {
                            "third -> 1",
                            "third -> 2"
                        }
                    }
                }
            };
            
            var iterator = tree.GetIterator();
            var item = iterator.Current();
            // Iterate the object
            while (!iterator.IsDone())
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            Console.WriteLine($"Total count: {tree.Count()}");
        }

    }
}
