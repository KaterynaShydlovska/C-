// Reversed Words

public class Kata
{
  public static string ReverseWords(string str)
  {
    string[] arr = str.Split(' ');


    string[] output = new string[arr.Length];
    
    for(var i = arr.Length; i>0; i--)
      {
      output[arr.Length -i] = arr[i-1];
    }

    string result = string.Join(" ", output);
        return result;
  }
}

//Reversed sequence

using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] array = new int[n];
    
    for( int i=n; i >=1; i--)
      {
      array[n-i] = i;
    }
    return array;
  }
}

//Reversed Strings

using System;

public static class Kata
{
  public static string Solution(string s) 
  {
//     throw new NotImplementedException("TODO: Kata.Solution(string) => string");
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
  }
}

// We want an array, but not just any old array, an array with contents!

// Write a function that produces an array with the numbers 0 to N-1 in it.

// For example, the following code will result in an array containing the numbers 0 to 4:

// arr(5) // => [0,1,2,3,4]

public class Kata
{
  public static int[] Arr(int N)
    
  {
    int[] array = new int[N];
    if(N == 0)
      return array;
    for(var i=array.Length -1 ; i>=0; i--)
      {
      N--;
      array[i] =N ;
    }
    return array;
  }
}

// Your task is to create functionisDivideBy (or is_divide_by) to check if an integer number is divisible by each out of two arguments.
// A few cases:

// (-12, 2, -6)  ->  true
// (-12, 2, -5)  ->  false

public class Kata
{
    public static bool is_divide_by(int number, int a, int b)
    {
        if(number % a == 0 && number % b == 0)
          {
          return true;
        }
          return false;
    }
}

// Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.

// Examples
// Input: [1, 5.2, 4, 0, -1]
// Output: 9.2

// Input: []
// Output: 0

// Input: [-2.398]
// Output: -2.398

public class Kata
{
  public static double SumArray(double[] array)
  {
    if(array.Length == 0)
      return 0;
    
    double sum =0;
    
    for(var i=0; i < array.Length; i++)
      sum+= array[i];
    return sum;
  }
}

// or

using System.Linq;

public class Kata
{
  public static double SumArray(double[] array)
  {
    return array.Sum();
  }
}

// As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.

// The input to the function will be an array of three distinct numbers (Haskell: a tuple).

// For example:

// gimme([2, 3, 1]) => 0
// 2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.

// Another example (just to make sure it is clear):

// gimme([5, 10, 14]) => 1
// 10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.


using System;
public class Kata
{
  public static int Gimme(double[] inputArray)
  {
      double one = inputArray[0];
      double two = inputArray[1];
      double three = inputArray[2];
      if((one > two && one < three) || (one > three && one < two))
      {
          return 0;
      }
      if((two > one && two < three) || (two < one && two > three))
      {
          return 1;
      }
      if((three > one && three < two) || (three < one && three > two))
      {    
          return 2;
      }    
      return 0;
  }
}

// Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.

// The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. Examples:

// setAlarm(true, true) -> false
// setAlarm(false, true) -> false
// setAlarm(false, false) -> false
// setAlarm(true, false) -> true

public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    if(employed == true && vacation == false)
      {
      return true;
    }
    return false;
  }
}

// The Story:
// Bob is working as a bus driver. However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he will be able to fit all the passengers.

// Task Overview:
// You have to write a function that accepts three parameters:

// cap is the amount of people the bus can hold excluding the driver.
// on is the number of people on the bus excluding the driver.
// wait is the number of people waiting to get on to the bus excluding the driver.
// If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.

using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    if((on + wait) == cap || (on + wait) < cap)
      {
      return 0;
    }
    return (on + wait) - cap;
  }
}


// Linked Kist

using Sysytem;
using Sysytem.Collections.Generic;
using Sysytem.Linq;
using Sysytem.Text;
using Sysytem.Treading.Tasks;

using System;



namespace DataStructureAndAlgorithms.LinkedList
{

  class MainClass {
  public static void Main (string[] args) {
    
    SimpleLinkedList list = new SimpleLinkedList();
    list.AddLast("kate");
    list.AddLast("hulk");
    list.AddFirst("mac");
    list.AddLast("andrii");
    list.AddLast(22);
    list.ReadAll();
    list.Reverse();
    list.ReadAll();
  }
}
  //  This class represents a node in the linked list
  public class Node 
  {
   public object data = null;
   public Node next = null;

   public Node(object data, Node next=null)
   {
     this.data = data;
     this.next = next;
   }
  }
  // this class will have the logic
  // to connect the node objects to create
  // link list structure
  public class SimpleLinkedList
  {
    Node head = null;

    public void AddLast(object data)
    {
       Node newItem = new Node(data);
       if(head == null)
       {  
        head = newItem;
        head.next = null;
       }
       else
       {
           Node runner = head;
             while(runner.next != null)
             {
               runner = runner.next;
             }
             runner.next = newItem;      
       }
    }
    public void AddFirst(object data)
    {
       Node newItem = new Node(data);
       if(head == null)
       {
        head = newItem;
       }
       else
       {
         Node oldHead = head;
         head = newItem;
         head.next = oldHead;
       }
    }

    public void ReadAll()
    {
        Node current = head;

        while(current != null)
        {
          Console.WriteLine(current.data);
          current = current.next;
          
        }
    }

    public void Reverse()
 {
     Node cur = head;
     Node next = null;
     while (cur != null) {
     Node tmp = cur.next;
     cur.next = next;
     next = cur;
     cur = tmp;
}
     head = next;           
   }
 }
}

// is List circular

static bool isCircular( Node head)  
{  
    // An empty linked list is circular  
    if (head == null)  
    return true;  
  
    // Next of head  
    Node node = head.next;  
  
    // This loop would stop in both cases (1) If  
    // Circular (2) Not circular  
    while (node != null && node != head)  
    node = node.next;  
  
    // If loop stopped because of circular  
    // condition  
    return (node == head);  
}  
using System; 
public class GFG  
{  
      
/* Link list Node */
public class Node  
{  
    public int data;  
    public Node next;  
}  
  
/*This function returns true if given linked  
list is circular, else false. */
static bool isCircular( Node head)  
{  
    // An empty linked list is circular  
    if (head == null)  
    return true;  
  
    // Next of head  
    Node node = head.next;  
  
    // This loop would stop in both cases (1) If Circular , (2) Not circular  
    while (node != null && node != head)  
    node = node.next;  
  
    // If loop stopped because of circular  
    // condition  
    return (node == head);  
}  
  
// Utility function to create a new node.  
static Node newNode(int data)  
{  
    Node temp = new Node();  
    temp.data = data;  
    temp.next = null;  
    return temp;  
}  
  
/* Driver code*/
public static void Main(String []args)  
{  
    /* Start with the empty list */
    Node head = newNode(1);  
    head.next = newNode(2);  
    head.next.next = newNode(3);  
    head.next.next.next = newNode(4);  
  
    Console.Write(isCircular(head)? "Yes\n" :  
                    "No\n" );  
  
    // Making linked list circular  
    head.next.next.next.next = head;  
  
    Console.Write(isCircular(head)? "Yes\n" :  
                    "No\n" );  
  
}  
}  


// Stack;

using System;
using System.Collections;

namespace StackImplementation
{

  public class program
  {

      public static void Main(string[] args)
      {
          Stack myStack = new Stack();
          myStack.Push("hello there");
          myStack.Push(1);
          myStack.Push(2);
          myStack.Push(3.5);
          // myStack.Push(null);
          myStack.Push("End of stack");

          Console.WriteLine($"Here is peak  {myStack.Peek()}");
          Console.WriteLine("Here is length of stack =>" + myStack.Count);

          myStack.Pop();

          Console.WriteLine($"Here is peak  {myStack.Peek()}");
          Console.WriteLine("Here is length of stack =>" + myStack.Count);
          Console.WriteLine("My stack has 2 =>" + myStack.Contains(2));
          Console.WriteLine("My stack has 3 =>" + myStack.Contains(3));

          myStack.Clear();

          foreach (var item in myStack)
          {
              Console.WriteLine(item);
          }

      }
  }
}

// Queue

using System;
using System.Collections;

namespace StackImplementation
{

  public class program
  {

      public static void Main(string[] args)
      {
        Queue myQueue = new Queue();
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);

        myQueue.Dequeue();
        Console.WriteLine("here it is => " + myQueue.Peek());
        Console.WriteLine("Contains 100 " + myQueue.Contains(100));

        Console.WriteLine("Length is  " + myQueue.Count);
        foreach(var num in myQueue)
        {
          Console.WriteLine(num);
        }

      }
  }
}

// HashTable

using System;
using System.Collections;
using System.Collections.Generic;


namespace HashTableProject
{

  public class MainClass
  {
    static Hashtable userInfoHash;
   


      public static void Main(string[] args)
      {
         userInfoHash = new Hashtable();
        
        //  Adding

        for(int i =0; i< 10; i++)
        {
          userInfoHash.Add(i, "user" + i);
        }

        // Removing
        if(userInfoHash.ContainsKey(0))
        {
          userInfoHash.Remove(0);
        }

        // Setting
        if(userInfoHash.ContainsKey(1))
        {
          userInfoHash[1] = "replacementName";
        }

        // looping
        foreach (DictionaryEntry  entry in userInfoHash)
        {
          Console.WriteLine("Key: " + entry.Key + "/Value: " + entry.Value);
        }
   
        }
      }
  }

  // Dictionary


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;




namespace Demo
{

  public class Program
  {
  public static void Main(string[] args)
      {
        Customer customer1 = new Customer()
        {
          ID = 100,
          Name = "Kate",
          Salary = 6400
        };

          Customer customer2 = new Customer()
        {
          ID = 119,
          Name = "Mac&Hulk",
          Salary = 400
        };

          Customer customer3 = new Customer()
        {
          ID = 110,
          Name = "Andrii",
          Salary = 10500
        };

        Dictionary<int, Customer> dictionartCustomers = new Dictionary<int, Customer>();
      // Adding
        dictionartCustomers.Add(customer1.ID, customer1);
        dictionartCustomers.Add(customer2.ID, customer2);
        dictionartCustomers.Add(customer3.ID, customer3);

      // method TryGetValue()
        Customer existCust;
        if(dictionartCustomers.TryGetValue(111, out existCust))
        {
          Console.WriteLine("ID ={0}, Name = {1}, Salary = {2}", existCust.ID, existCust.Name, existCust.Salary);
        }
        else{
          Console.WriteLine("The key is not foud");
        }

        // Count

        Console.WriteLine("total items = {0} ", dictionartCustomers.Count);
        //or
        Console.WriteLine("total items = {0} ", dictionartCustomers.Count(kvp => kvp.Value.Salary > 4000));
       
       //Remove one  or all 
        dictionartCustomers.Remove(100);
         Console.WriteLine("total items = {0} ", dictionartCustomers.Count);

        //  dictionartCustomers.Clear();


        Customer cust = dictionartCustomers[119];
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
      //foeach may use var also
        foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionartCustomers)
        {
          Console.WriteLine("ID ={0} ", customerKeyValuePair.Key);

          Customer custom = customerKeyValuePair.Value;
          Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", custom.ID, custom.Name, custom.Salary);
          Console.WriteLine("---------------------------");
        }


        //Contains() method
        if(!dictionartCustomers.ContainsKey(customer1.ID))
        {
             dictionartCustomers.Add(customer1.ID, customer3);
        }

        if(dictionartCustomers.ContainsKey(129))
        {
          Console.WriteLine("Here");
        }
        else
        {
           Console.WriteLine("not found");
        }
     
        }

      }

      public class Customer
      {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
      }
  }


// Coverting array to Dictionary

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{

  public class Program
  {
  public static void Main(string[] args)
      {
        Customer customer1 = new Customer()
        {
          ID = 100,
          Name = "Kate",
          Salary = 6400
        };

          Customer customer2 = new Customer()
        {
          ID = 119,
          Name = "Mac&Hulk",
          Salary = 400
        };

          Customer customer3 = new Customer()
        {
          ID = 110,
          Name = "Andrii",
          Salary = 10500
        };
       
       // List to Dictionary
        // List<Customer> customers = new List<Customer>();
        // customers.Add(customer1);
        // customers.Add(customer2);
        // customers.Add(customer3);

        //Array to dictionary
        Customer[] customers = new Customer[3];
        customers[0] = customer1;
        customers[1] = customer2;
        customers[2] = customer3;

       Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

       foreach(KeyValuePair<int, Customer> kvp in dict)
       {
         Console.WriteLine("Key ={0}", kvp.Key);
         Customer cust = kvp.Value;
          Console.WriteLine("ID ={0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

       }

    }

  }

      public class Customer
      {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
      }
  }

// Codewars Bar recommends you drink 1 glass of water per standard drink so you're not hungover tomorrow morning.
// Your fellow coders have bought you several drinks tonight in the form of a string. Return a string suggesting how many glasses of water you should drink to not be hungover.
// Examples
// "1 beer"  -->  "1 glass of water"
// because you drank one standard drink
// "1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer"  -->  "10 glasses of water"
// because you drank ten standard drinks
using System;
public class Drinkin
{
    public string hydrate(string drinkString)
    {
     int sum = 0;
     int j = 0;
      string[] arr = drinkString.Split(' ');
      for(int i=0; i< arr.Length; i++ )
        {
        bool result = int.TryParse(arr[i], out j);
        if(result == true)
          {
          sum+= j;
        }
      }
      if(sum == 1)
        {
        return $"{sum} glass of water";
      }
      else{
        return $"{sum} glasses of water";
      }
      

// In this Kata, you will be given an array of unique elements, and your task is to rerrange the values so that the first max value is followed by the first minimum, followed by second max value then second min value, etc.

// For example:

// Kata.Solve(new List<int> {15,11,10,7,12}) => new List<int> {15,7,12,10,11}
// The first max is 15 and the first min is 7. The second max is 12 and the second min is 10 and so on.


using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<int> arr)
  {
    arr.Sort();
    List<int> result = new List<int>();
    
    int i=0;
    int j = arr.Count-1;
    
    
    while(i <=j)
      {
      if(i == j ){
        result.Add(arr[i]);
      }
      else{
        result.Add(arr[j]);
      result.Add(arr[i]);
      }
      j--;
      i++;
    }
    
    return result;
    
  }
}

// Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.
using System;
public class Kata
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int mult = array[0] * array[1];
      
      int i=0;
      int j =i+1; 
       
      while(j < array.Length)
        {
        int temp = array[i] * array[j];
        if(temp > mult)
          {
          mult = temp;
        }
        i++;
        j++;
      }
          Console.WriteLine(mult);  
      return mult;
    }
}

// An ordered sequence of numbers from 1 to N is given. One number might have deleted from it, then the remaining numbers were mixed. Find the number that was deleted.

// Example:

// The starting array sequence is [1,2,3,4,5,6,7,8,9]
// The mixed array with one deleted number is [3,2,4,6,7,8,1,9]
// Your function should return the int 5.
// If no number was deleted from the array and no difference with it, your function should return the int 0.

// Note that N may be 1 or less (in the latter case, the first array will be []).

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
  {
      return startingList.Sum() - mixedList.Sum();
  }
}

// Sort Numbers

// Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.

// For example:

// SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
// SortNumbers(null); // should return new int[] { }

using System;
using System.Collections.Generic;
public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    if(nums == null || nums.Length == 0 )
      {
       return new int[0];
    }
  else
  {
    Array.Sort(nums);
   }
    return nums;
  }
}

// You receive the name of a city as a string, and you need to return a string that shows how many times each letter shows up in the string by using asterisks (*).

// For example:

// "Chicago"  -->  "c:**,h:*,i:*,a:*,g:*,o:*"
// As you can see, the letter c is shown only once, but with 2 asterisks.

// The return string should include only the letters (not the dashes, spaces, apostrophes, etc). There should be no spaces in the output, and the different letters are separated by a comma (,) as seen in the example above.

// Note that the return string must list the letters in order of their first appearance in the original string.

// More examples:

// "Bangkok"    -->  "b:*,a:*,n:*,g:*,k:**,o:*"
// "Las Vegas"  -->  "l:*,a:**,s:**,v:*,e:*,g:*"

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string GetStrings(string city)
    {
      
       Dictionary <char, string>cities = new Dictionary<char, string>();
      
      city = city.ToLower().Replace(" ", "");;
      
      for(int i=0; i< city.Length; i++)
        {
        if(cities.ContainsKey(city[i]))
        {
          cities[city[i]] = cities[city[i]] + "*";
        }
        else 
          {
          cities.Add(city[i], "*");
        }
      }
    
  string s = string.Join(",", cities.Select(x => x.Key + ":" + x.Value).ToArray());
  return s;
   }
}

// The company you work for has just been awarded a contract to build a payment gateway. In order to help move things along, you have volunteered to create a function that will take a float and return the amount formatting in dollars and cents.

// 39.99 becomes $39.99

// The rest of your team will make sure that the argument is sanitized before being passed to your function although you will need to account for adding trailing zeros if they are missing (though you won't have to worry about a dangling period).

// Examples:

// 3 needs to become $3.00

// 3.1 needs to become $3.10

using System;
using System.Globalization;
public class Kata
{
  public static string FormatMoney(double amount)
  {
   return amount.ToString("$0.00");
  }
}

// Given a string as input, return a new string with each letter pushed to the right by its respective index in the alphabet.

// We all know that A is a slow and Z is a fast letter. This means that Z gets shifted to the right by 25 spaces, A doesn't get shifted at all, and B gets shifted by 1 space.

// You can assume the following things about your input:

// It will only contain uppercase letters from A to Z, no whitespaces or punctuation;
// Input strings will not exceed 100 characters (although your output string might!)
// Note that if 2 or more letters fall onto the same space after shifting, the latest character will be used. For example: "BA" -> " A"

// Examples
// "AZ"   -->  "A                         Z"
// "ABC"  -->  "A B C"
// "ACE"  -->  "A  C  E"
// "CBA"  -->  "  A"
// "HELLOWORLD"  -->  "     E H    DLL   OLO   R  W"

using System;
using System.Collections.Generic;
using System.Text;
class Kata
{
    public static string Speedify(string input)
    {
      
      IDictionary<char, int> obj = new Dictionary<char, int>();
       string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      
      char[] output = new char[1000];
      
      for(var i=0; i< alphabet.Length; i++)
        {
        obj.Add(alphabet[i], i+1);
      }
      
      for(var j = 0; j < input.Length; j++)
        {
         if(obj.ContainsKey(input[j]))
           {
           output[obj[input[j]] + j-1] = input[j];
         }
      }
      
      string str = string.Concat(output);
        return str.Replace( '\0', ' ' ).TrimEnd();
    }
}


// Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.

// The Task
// Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
// Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.

using System;
using System.Collections.Generic;

public static class Kata
    {
        public static string Greet(string language)
        {
           Dictionary<string, string> db = new Dictionary<string, string>()
             {
             {"english", "Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"}
           };
          
          
          if(db.ContainsKey(language))
            {
            return db[language];
          }
          else 
            {
            return "Welcome";
          }
          
        }

//   A trick I learned in elementary school to determine whether or not a number was divisible by three is to add all of the integers in the number together and to divide the resulting sum by three. If there is no remainder from dividing the sum by three, then the original number is divisible by three as well.

// Given a series of digits as a string, determine if the number represented by the string is divisible by three.

// You can expect all test case arguments to be strings representing values greater than 0.

// Example:

// "123"      -> true
// "8409"     -> true
// "100853"   -> false
// "33333333" -> true
// "7"        -> false

using System;

public static class Kata
{
  public static bool DivisibleByThree(string n)
  {
    int sum =0;
      for(var i=0; i< n.Length; i++)
        {
        sum += n[i];
        }
      if(sum % 3 ==0)
        {
        return true;
      }
      else
        {
        return false;
      }
        
    }
  }

//   Write a function that can return the smallest value of an array or the index of that value. The function's 2nd parameter will tell whether it should return the value or the index.

// Assume the first parameter will always be an array filled with at least 1 number and no duplicates. Assume the second parameter will be a string holding one of two values: 'value' and 'index'.

// min([1,2,3,4,5], 'value') // => 1
// min([1,2,3,4,5], 'index') // => 0

using System;

public class Kata
{
  public static int FindSmallest(int[] numbers, string toReturn)
  {
    
    int min = numbers[0];
    int minIndex =0;
    
    for(var i =0; i< numbers.Length; i++)
      {
      if(min > numbers[i])
        {
        min = numbers[i];
      }    
    }

    bool notFound = false;
    int j =0;
    while(!notFound)
      {
      if(numbers[j] == min)
        {
        notFound = true;
        minIndex = j;
      }
      j++;
    }
   
    
    if(toReturn == "index")
      {
      return minIndex;
    }
    else
      {
      return min;
    }    
  }
    

// Fellow code warrior, we need your help! We seem to have lost one of our sequence elements, and we need your help to retrieve it!

// Our sequence given was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

// Write a function that accepts a sequence of unique integers between 0 and 9 (inclusive), and returns the missing element.

// Examples:
// [0, 5, 1, 3, 2, 9, 7, 6, 4] --> 8
// [9, 2, 4, 5, 7, 0, 8, 6, 1] --> 3

using System;

public static class Kata
{
  public static int GetMissingElement(int[] superImportantArray)
  {
    int res = 0;
    Array.Sort(superImportantArray);
    
    for(var i=0; i<superImportantArray.Length-1; i++ )
      {
      if(superImportantArray[i+1] != superImportantArray[i]+1)
        {
        res = superImportantArray[i]+1;
      }
    }
    return res;
  }
}


// Given a non-negative integer n, write a function to_binary/ToBinary which returns that number in a binary format.

// Documentation:
// Kata.ToBinary Method (Int32)
// Returns the binary representation of a non-negative integer as an integer.
// Parameters
// n
// Type: System.Int32
// The integer to convert.

// Return Value
// Type: System.Int32
// The binary representation of the argument as an integer.
// to_binary(1)  /* should return 1 */
// to_binary(5)  /* should return 101 */
// to_binary(11) /* should return 1011 */

using System;

public static class Kata
{
  public static int ToBinary(int n)
  {
     string binary = Binary(n);
    return Int32.Parse(binary);
  }


    public static string Binary(int x)
    {
        char[] buff = new char[32];
 
        for (int i = 31; i >= 0 ; i--) {
            int mask = 1 << i;
            buff[31 - i] = (x & mask) != 0 ? '1' : '0';
        }
 
        return new string(buff);
    }
 
//  This function takes two numbers as parameters, the first number being the coefficient, and the second number being the exponent.

// Your function should multiply the two numbers, and then subtract 1 from the exponent. Then, it has to print out an expression (like 28x^7). "^1" should not be truncated when exponent = 2.

// For example:

// derive(7, 8)
// In this case, the function should multiply 7 and 8, and then subtract 1 from 8. It should output "56x^7", the first number 56 being the product of the two numbers, and the second number being the exponent minus 1.

// derive(7, 8) --> this should output "56x^7" 
// derive(5, 9) --> this should output "45x^8" 

public class Kata
{
  public static string Derive(double coefficient, double exponent)
  {
    double res = coefficient * exponent;
    return $"{res}x^{exponent-1}";
    
  }
}

////
// Problem 1: Array Max Result
// Problem Statement
// Given an array select a number that exists, and output the computated “score”. The method you create should take in both an array of integers and the integer the user selected.

// Create a Console application that requests 5 numbers between 1-10 from the user. Output the array to the console and ask the user to select a number. After the selection, output the “score” of the number chosen.

// Selection and Scoring Algorithm
// You can select any number from the list, however your scoring will be depend on the frequency of that number in the list. E.g for [2,2,3,5,4] if you pick 2 your score will be 4 (2 * 2) but if you pick 5 your score will be 5 (5 * 1)

// Input Format
// An array of integers, and the number chosen.

// Sample Input
// [6,4,4,1,3] , 4

// Sample Output
// 8

using System;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            
            int counter = 0;
            while (counter < 5)
            {
                counter = GetNumbers(counter, numbers);
            }

            ShowResult(numbers);
        }

        private static int GetNumbers(int counter, int[] numbers)
        {
            Console.Clear();
            Console.Write("Please choose a number between 1 to 10. Same number can be chosen multiple times. ({0}/5): ", counter);
            string numberInput = Console.ReadLine();
            
            if (int.TryParse(numberInput, out int number) && 0 < number && number < 10)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        numbers[i] = number;
                        break;
                    }
                }
                counter++;

                if (counter < 5)
                {
                    Console.Clear();
                    Console.WriteLine("You have entered '{0}'. Press 'Enter' to choose another number. ({1}/5).", number, counter);
                    Console.ReadLine();
                    return counter;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have entered '{0}'. Press 'Enter' to continue. ({1}/5).", number, counter);
                    Console.ReadLine();
                    return counter;
                }
            }
            else
            {
                Console.WriteLine("That was an invalid entry. Press 'Enter' to try again.");
                Console.ReadLine();
                return counter;
            }
        }

        private static void ShowResult(int[] numbers)
        {
            Console.Clear();
            Console.Write("You have entered [" + string.Join(", ", numbers) + "]. Please select a number from the list for a score: ");
            int selectedNumber = int.Parse(Console.ReadLine());

            int score = 0;
            while(score ==0)
            {
                for(var i=0; i< numbers.Length; i++)
                {
                  if(numbers[i] == selectedNumber)
                  {
                    score+=1;
                  }
                
                }
                score = score* selectedNumber;

                if (score != 0)
                {
                    Console.WriteLine("Your score is {0}", score);
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("That was an invalid entry. Please select a number from [" + string.Join(", ", numbers) + "] for a score: ");
                    selectedNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}

////
//Calculator

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         bool displayMenu = true;
         while(displayMenu)
         {
           displayMenu = MainMenu();
         }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers you would like to work with below.");
            Console.Write("Number One: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Number Two: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("You entered {0} and {1}.", a, b);
            Console.WriteLine("");

            Console.WriteLine("Choose which function to run:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("");
            Console.Write("Function: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Console.Clear();
                Console.WriteLine("{0} + {1} = {2}", a, b, Add(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "2")
            {
                Console.Clear();
                Console.WriteLine("{0} - {1} = {2}", a, b, Subtract(a, b));
                Console.WriteLine("");
                Console.WriteLine("Please press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "3")
            {
                Console.Clear();
                Console.WriteLine("{0} * {1} = {2}", a, b, Mult(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "4")
            {
                Console.Clear();
                Console.WriteLine("{0} / {1} = {2}", a, b, Divide(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else
            {
                return false;
            }
        }

        private static decimal Add(decimal a, decimal b)
        {
         return a + b;
        }

         private static decimal Subtract(decimal a, decimal b)
        {
          return a - b;
        }

         private static decimal Mult(decimal a, decimal b)
        {
          return a * b;
        }

         private static decimal Divide(decimal a, decimal b)
        {
          return a / b;
        }
    }
}

// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for(var i=0; i< str.Length; i++)
          {
          if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
            vowelCount++;
          }
        }

        return vowelCount;
    }
}

///
// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

// Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.

using System;
using System.Collections.Generic;

public static class Kata
{
 public static bool IsPangram(string str)
  {
    string newStr = str.ToLower().Replace(" ", "").Replace(".", "");
    bool found = true;
    Console.WriteLine(newStr);
    Dictionary<char, bool> d = new Dictionary<char, bool>();
   d.Add('a', true);
   d.Add('b', true);
   d.Add('c', true);
   d.Add('d', true);
   d.Add('e', true);
   d.Add('f', true);
   d.Add('g', true); 
   d.Add('h', true);
   d.Add('i', true);
   d.Add('j', true);
   d.Add('k', true);
   d.Add('l', true);
   d.Add('m', true);
   d.Add('n', true);
   d.Add('o', true);
   d.Add('p', true);
   d.Add('q', true);
   d.Add('r', true);
   d.Add('s', true);
   d.Add('t', true);
   d.Add('u', true);
   d.Add('v', true);
   d.Add('w', true);
   d.Add('x', true);
   d.Add('y', true);
   d.Add('z', true);
    
    for(var i=0; i< newStr.Length; i++)
      {
        Console.WriteLine(d.ContainsKey(newStr[i]));
      if(d.ContainsKey(newStr[i]))
        {
        d.Remove(newStr[i]);
      }
    }
      if(d.Count > 0)
      {
        found =false;
      }
       return found;
  }
}


















