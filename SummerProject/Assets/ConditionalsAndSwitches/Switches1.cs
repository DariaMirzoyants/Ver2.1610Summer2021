using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches1 : MonoBehaviour
{
    static void Main(string[] args)
    {
        int day = 4;
        switch (day)
        {
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }
    }
}

