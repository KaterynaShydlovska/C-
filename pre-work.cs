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

/////////////////////git