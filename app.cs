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

        dictionartCustomers.Add(customer1.ID, customer1);
        dictionartCustomers.Add(customer2.ID, customer2);
        dictionartCustomers.Add(customer3.ID, customer3);

        Customer cust = dictionartCustomers[119];
        // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

        foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionartCustomers)
        {
          Console.WriteLine("ID ={0} ", customerKeyValuePair.Key);

          Customer custom = customerKeyValuePair.Value;
          Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", custom.ID, custom.Name, custom.Salary);
          Console.WriteLine("---------------------------");
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





















