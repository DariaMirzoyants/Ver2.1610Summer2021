using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals2 : MonoBehaviour
{
    static void Main(string[] args)
    {
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
    }
}

