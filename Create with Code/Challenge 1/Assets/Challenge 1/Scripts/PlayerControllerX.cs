﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 10.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up, turnSpeed * verticalInput * Time.deltaTime);
    }
}
