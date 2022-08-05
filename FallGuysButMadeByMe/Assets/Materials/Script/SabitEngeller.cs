using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SabitEngeller : MonoBehaviour
{
    
    
    
    private void OnCollisionEnter(Collision cisim)
    {
        if (cisim.gameObject.tag == "Bot")
        {
            Destroy(cisim.gameObject);

        }
        if(cisim.gameObject.tag == "Karakter")
        {
            cisim.gameObject.transform.Translate(0,1,0);
            cisim.gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * 3000);
            Debug.Log("Temas");
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
