using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame1 : MonoBehaviour
{
    GameObject nesne;
    private void OnCollisionEnter(Collision nesne)
    {
        if (nesne.gameObject.tag == "Karakter")
        {
            SceneManager.LoadScene(0);
            
        }
        if (nesne.gameObject.tag == "Bot")
        {
            Destroy(nesne.gameObject);

        }

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
