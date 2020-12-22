using System;
using System.Text;
using System.Runtime;

class MainClass {
  public static void Main (string[] args)
  {
  ConcatStreengs("Hello ", "my name is ", "Kate!");
  ChangeArray(new int[] { 1, 3, 5, 7, 9 }, 2, 10);

  NewString("to be or not to be");

  CutString("Hello there!", 2, 7);
  // CutString("Hello there!");
  // CutString("Hello there!", 0, 0);
  CutString("Hello there!", 2);
  // CutString("Hello there!", null, 7);

Console.WriteLine(SameArrays(new int[] {1,2,3,4}, new int[] {1,7,3,4}));

SumDifAndEct(5, 5);
int strIndex = -5;
Console.WriteLine(Character("Mr Hulk and BigMac", ref strIndex));
 }


public static string ConcatStreengs(string s1, string s2, string s3)
{
  string result = s1 + s2 + s3;
  Console.WriteLine(result);
  return result;
}

public static void ChangeArray(int[] arr, int index, int val)
{
  if(index < arr.Length)
  {
   arr[index] = val;
  }
  foreach(var num in arr)
  {
    Console.WriteLine(num);
  }

}

public static string NewString(string oldStr)
{
  StringBuilder sb = new StringBuilder();

 string[] subs = oldStr.Split(' ');

 for(var i=0; i< subs.Length; i+=2)
 {
   sb.Append(subs[i]);
   sb.Append(" ");
 }
 Console.WriteLine(sb.ToString().Trim());
 return sb.ToString().Trim();
}

public static string CutString(string str, int index = 0, int len = 0)
{
  if(index > str.Length || len > str.Length)
  {
    return "";
  }
  if(len == 0)
  {
    len = str.Length-1;
  }
 Console.WriteLine(str.Length); 
Console.WriteLine(index);
Console.WriteLine(len);
string substring = str.Substring(index, len);

Console.WriteLine(substring);
return substring;
}

public static bool SameArrays(int[] arr1, int[] arr2)
{
int i=0;
int j =0;
while(i< arr1.Length || j < arr2.Length)
{
  if(arr1[i] != arr2[j])
  {
    return false;
  }
  i++;
  j++;
}
return true;
}

public static void SumDifAndEct(int n, int m)
{
  Console.WriteLine(n+m);
  Console.WriteLine(n-m);
  Console.WriteLine(n*m);
  Console.WriteLine(n/m);
}

public static char Character(string s, ref int index)
{
  if(index < 0){
    index = 0;
    return s[0];
  }
  else if(index >= s.Length)
  {
    index = s.Length -1;
    return s[s.Length -1];
  }
  else
  {
    return s[index];
  }
}
}