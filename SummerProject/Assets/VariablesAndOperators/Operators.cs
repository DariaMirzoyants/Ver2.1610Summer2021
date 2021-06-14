using System.Collections;

using System.Collections.Generic;
{
   using UnityEngine;
   {
     public class Operators : MonoBehaviour
      {
        int sum1 = 100 + 50;
        int sum2 = sum1 + 250;
        int sum3 = sum2 + sum2;
        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
        int x = 5;
        int y = 3;
        Console.WriteLine(x + y);
        Console.WriteLine(x - y);
        Console.WriteLine(x * y);
        Console.WriteLine(x / y);
        Console.WriteLine(x % y);
        x++;
        Console.WriteLine(x);
        x--;
        Console.WriteLine(x);
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
        Console.WriteLine(x > 3 && x < 10);
        Console.WriteLine(x > 3 || x < 4);
        Console.WriteLine(!(x > 3 && x < 10));
        }
   }
}
