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

