using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector3 direction;
    private Vector3 finalTranslate;

    private float zDestroy = -20.0f;
    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        //direction = new Vector3(0, 1, 0);
        Debug.Log(direction);

        finalTranslate = Vector3.Scale(direction, new Vector3(speed,speed,speed));
        Debug.Log(finalTranslate);
    }

    // Update is called once per frame
    void Update()
    {
        //objectRb.AddForce(Vector3.forward * -speed);
        transform.Translate(finalTranslate * Time.deltaTime);

        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
