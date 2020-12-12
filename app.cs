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
