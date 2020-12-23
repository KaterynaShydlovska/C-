using System;
// Hello World
class HelloWorld {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  


// Comments
// 1. Single Comments

/* 2. multi-Line
comment block
*/

/// <summary>
/// 3.XML doc comment
/// </summary>


// Variables

bool boollian = true;
Console.WriteLine(boollian);
int n = 2;
Console.WriteLine(n);
double m = 2.5;
Console.WriteLine(m);
char a = 'a';
Console.WriteLine(a);
string s = "string";
Console.WriteLine(s);

// Min/Max values

int minVal = Int32.MinValue;
Console.WriteLine(minVal);
int maxVal = Int32.MaxValue;
Console.WriteLine(maxVal+1);

//Implicit types

var trueOrFalse = false;
var num = 20;
var doubleNum = 30.45;
var character  =  'b';
var str = "string...";

//Operators

int x =5;
int y =23;

int z1 = x++;
int z2 = ++y;
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("z1 = " + z1);
Console.WriteLine("z2 = " + z2);



  }
}

///////

using System;

class MainClass {
  public static void Main (string[] args) {

    string str = "0123456789";

    int i =0;
    while(i< str.Length)
    {
      if(str[i] % 2 !=0)
      {
      Console.WriteLine("odd num: " + str[i]);
      }
      i++;
    }
    Console.WriteLine("----------------------------- nextdo while->");
    int k =0;
    do
    {
      if(str[k] % 2 !=0)
      Console.WriteLine("odd num: " + str[k]);
      k++;
    }
    while(k< str.Length);

 Console.WriteLine("----------------------------- next for loop->");
    for(int j =0; j< str.Length; j ++)
    {
      if(str[j] % 2 !=0)
      Console.WriteLine("odd num: " + str[j]);
    }

   Console.WriteLine("----------------------------- next foreach->");
  foreach(var n in str)
  {
    if(n % 2 != 0)
    {
      Console.WriteLine(n);
    }
  }


  
  }
}

/////////

using System;

class MainClass {
  public static void Main (string[] args) {

 string s = "i created new string.";

int i=0;
int j = 1;

while(i< s.Length)
{
  while(j < s.Length)
  {
    if(s[i] == s[j])
    {
     Console.WriteLine(s[i]);
    }
    j++;
  }
  i++;
  }
 }
}

//////////////////////////

using System;

class MainClass {
  public static void Main (string[] args) {

 int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for(int i = arr.Length-1; i >= 0; i--)
{
  Console.WriteLine(arr[i]);
}

int sum =0;
foreach(int n in arr)
{
  sum+=n;
}
Console.WriteLine(sum);

string result = string.Join(".", arr);
Console.WriteLine($"RESULT: {result}");

 }
}

/////////////////////
//command-line application using character escape sequences
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");