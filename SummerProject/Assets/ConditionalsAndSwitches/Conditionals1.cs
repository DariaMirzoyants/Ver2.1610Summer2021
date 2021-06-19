using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int time = 22;
        if (time< 10)
    {
        Console.WriteLine("Good morning.");
    }

    else if (time<20)
    {
        Console.WriteLine("Good day");
    }

    else
    {
        Console.WriteLine("Good evening");
    }
}



