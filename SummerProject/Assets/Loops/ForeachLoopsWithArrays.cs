using System.Collections;
using System.Collections.Generic;
using UnityEngine;
{
  public class ForeachLoopsWithArrays : MonoBehaviour
   {
    static void Main(string[] args)
     {
       string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
       for (int i = 0; i < cars.Length; i++)
       {
         Console.WriteLine(cars[i]);
       }
     }
   }
}