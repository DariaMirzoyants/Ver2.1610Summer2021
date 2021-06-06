using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start ()
    {
        Debug.Log(transform.positions.x);

        if (transform.positions.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
