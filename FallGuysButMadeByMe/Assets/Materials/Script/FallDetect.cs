using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetect : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.y< -34)
        {
            SceneManager.LoadScene(0); 
        }
    }
}
