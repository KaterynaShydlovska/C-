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
