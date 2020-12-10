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

```
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

      
        static void Main(string[] args)
        {

            //Create List with integers
            var nums = new List<int>() { 1, 2, 3, 4 };

            //Add new int to List
            nums.Add(1);

            //Add array of int to List
            nums.AddRange(new int[3] { 5, 6, 7 });

            foreach(var n in nums)
            Console.WriteLine(n);

            //Indexof()
            Console.WriteLine("Index: " + nums.IndexOf(1));

            //Last Index
            Console.WriteLine("Index: " + nums.LastIndexOf(1));

            //Length of List
            Console.WriteLine("Count: " + nums.Count);

            //Remove from list
            //nums.Remove(1);

            for (var n=0; n< nums.Count; n++)
            {
                if(nums[n] == 1)
                    nums.Remove(nums[n]);    
            }
            foreach (var n in nums)
                Console.WriteLine(n);


            //Clear()
            nums.Clear();
            Console.WriteLine("Count: " +nums.Count);
        }
    }
}

```

```
namespace ConsoleApp1
{
    class Program
    {

      
        static void Main(string[] args)
        {

            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }
    }
}
```
```
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

      
        static void Main(string[] args)
        {

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //ToString
            Console.WriteLine("To string :" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse :" + TimeSpan.Parse("01:02:03"));



        }
    }
}

```
