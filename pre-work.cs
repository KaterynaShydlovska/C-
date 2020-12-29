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

/////
using System.Collections.Generic; 
using System; 

class GFG 
{ 

	// Utility function to print the contents 
	// of the ArrayList 
	static void printArrayList(List<String> arrL) 
	{ 
		arrL.Remove(""); 
		for (int i = 0; i < arrL.Count; i++) 
			Console.Write(arrL[i] + " "); 
	} 

	// Function to returns the arraylist which contains 
	// all the permutation of str 
	public static List<String> getPermutation(String str) 
	{ 

		// If string is empty 
		if (str.Length == 0) 
		{ 

			// Return an empty arraylist 
			List<String> empty = new List<String>(); 
			empty.Add(""); 
			return empty; 
		} 

		// Take first character of str 
		char ch = str[0]; 

		// Take sub-string starting from the 
		// second character 
		String subStr = str.Substring(1); 

		// Recurvise call 
		List<String> prevResult = getPermutation(subStr); 

		// Store the generated permutations 
		// into the resultant arraylist 
		List<String> Res = new List<String>(); 

		foreach (String val in prevResult) 
		{ 
			for (int i = 0; i <= val.Length; i++) 
			{ 
				Res.Add(val.Substring(0, i) + ch + val.Substring(i)); 
			} 
		} 

		// Return the resultant arraylist 
		return Res; 
	} 

	// Driver code 
	public static void Main(String[] args) 
	{ 


    List <int> l = new List<int> {1,2,3,4,5};
    String str = ""; 
    for(var i=0; i< l.Count; i++)
    {
     str += l[i];
    }

		
    Console.WriteLine(str);
		printArrayList(getPermutation(str)); 
	} 
} 
// same soution with loops

using System;
using System.Collections.Generic; 

class MainClass {
  public static void Main (string[] args) {
     string hat = "12345";
     getPermutation(hat);
  }

 

  public static void getPermutation(string hat)
  {
            
            for( var i = 0; i < hat.Length; i++)
            {
                for(var j = 0; j < hat.Length; j++)
                {
                    for(var z = 0; z < hat.Length; z++)
                    {
                        for (var a = 0; a < hat.Length; a++)
                        {
                            for (var b = 0; b < hat.Length; b++)
                            {
                                if (i != j && i != z && i != a && i != b && j != z && j != a && j != b && z != a && z != b && a != b)
                                {
                                    Console.WriteLine($"{hat[i]}{hat[j]}{hat[z]}{hat[a]}{hat[b]}");
                                }
                            }
                        }
                    }
                }


 
    }
  }
}

///

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (IsFirstCharRepeated("heh"));
  }

  public static bool IsFirstCharRepeated(String str)
  {
    bool isFound = false;

    char l = str[0];

    for(int i =1; i< str.Length; i++)
    {
      if(str[i] == l)
      {
        isFound = true;
      }
    }
    return isFound;
  }
}

/////
using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    string str = "123";
    Console.WriteLine(ReverseString(str));

  }

  public static string ReverseString(string str)
  {
    string res = "";
    // char n;

   for(var i = str.Length-1; i>=0; i--)
   {
   
    res+=str[i];
   }
   return res;
  }
}