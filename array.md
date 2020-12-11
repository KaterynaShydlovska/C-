# C#

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

```
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

      
        static void Main(string[] args)
        {
            var fullName = "Kateryna Shydlovska ";

            //Trim()
            Console.WriteLine("Trim: " + fullName.Trim());

            //ToUpper()
            Console.WriteLine("ToUpper: " + fullName.ToUpper());

            //ToLower()
            Console.WriteLine("ToLower: " + fullName.Trim().ToLower());

            //IndexOf
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            //Split()
            var name = fullName.Split(' ');
            Console.WriteLine("First name: " + name[0]);
            Console.WriteLine("Last name: " + name[1]);

            //Replace
            Console.WriteLine(fullName.Replace("Kateryna", "Kate"));

            //Empty string
            string str = null;
            if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
                Console.WriteLine("Invalid");

            //String to num
            string numStr = "124";
           Console.WriteLine(Convert.ToInt32(numStr));

            //Num to string
            float price = 29.95f;

            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
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
            var sentense = "This is going to be a really really really really long text";
            var summary = SummerizeText(sentense, 25);
            Console.WriteLine(summary);
        }

            static string SummerizeText(string text, int maxLength = 20)
            {
                if (text.Length < maxLength)
             
                return text;
                
                    var words = text.Split(" ");
                    var totalChar = 0;
                    var summaryWords = new List<string>();

                    foreach (var word in words)
                    {
                        summaryWords.Add(word);
                        totalChar += word.Length + 1;
                        if (totalChar > maxLength)
                            break;
                    }
                    return String.Join(" ", summaryWords) + "...";

        }
    }
}
```

```
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            //var builder = new StringBuilder("Hello World!);
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine(builder[0]);
        }

           
        
    }
}
```
