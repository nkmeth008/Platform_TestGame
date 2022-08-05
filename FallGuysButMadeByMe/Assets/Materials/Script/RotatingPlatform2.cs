using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform2 : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
     
        
    }

   
    void Update()
    {
        rb.useGravity = false;       
        rb.angularVelocity = Vector3.forward * -1.0f;    
        rb.angularDrag = 0.0f;
        
    }
}
