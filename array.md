# C-

```
using System;

namespace ConsoleApp1
{
    class Program
    {

      
        static void Main(string[] args)
        {
            int[] num = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine($"Length: {num.Length} ");
           

            //IndexO
            var index = Array.IndexOf(num, 9);
            Console.WriteLine($"Index: {index}");

            // Clear
            Array.Clear(num, 0, 2);
            Console.WriteLine("Num array:");
            foreach (var n in num)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(num, another, 3);
            Console.WriteLine("Another:");
            foreach (var el in another)
                Console.WriteLine(el);

            //Sort()
           Array.Sort(num);
            Console.WriteLine("Sorted:");
            foreach (var l in num)
                Console.WriteLine(l);

            //Rverese()
            Array.Reverse(num);
            Console.WriteLine("Reversed:");
            foreach (var j in num)
                Console.WriteLine(j);





        }
    }
}
```
