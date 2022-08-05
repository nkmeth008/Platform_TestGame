using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    GameObject finish;
    
    private void OnCollisionEnter(Collision finish)
    {
        if(finish.gameObject.tag == "Bot")
        {
            Destroy(finish.gameObject);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            
            
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
