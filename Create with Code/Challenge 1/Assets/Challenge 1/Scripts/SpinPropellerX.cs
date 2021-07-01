using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
 protected float degreesRemaining = 0F;
 
 public const float degreesPerSecond = 100F;
 
 public void AddRotation(float degrees)
 {
     this.degreesRemaining += degrees;
 }
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
     {
     if (this.degreesRemaining > 0F)
     {
         // how much the object should rotate this frame
         // degrees = degrees per second * seconds, and Time.deltaTime is a fraction of a second
         float rotationThisFrame = degreesPerSecond * Time.deltaTime;
         
         // if object would finish rotating this frame, finish rotating
         if (rotationThisFrame >= degreesRemaining)
         {
             this.transform.Rotate(new Vector3(0F, 0F, degreesRemaining);
             this.degreesRemaining = 0F;
         }
         else // otherwise, rotate the amount necessary and subtract that from the counter
         {
             this.transform.Rotate(new Vector3(0F, 0F, rotationThisFrame);
             this.degreesRemaining -= rotationThisFrame;
    }
}
