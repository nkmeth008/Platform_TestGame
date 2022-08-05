using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMovement : MonoBehaviour
{

    public float speed = 2.0f;
    public Vector3 startpos1;
    public Vector3 startpos2;

    public Transform currentPoint;
    public GameObject platform;
    GameObject nesne;
    private void OnCollisionEnter(Collision nesne)
    {
        if (nesne.gameObject.tag == "Bot")
        {
            
            Destroy(nesne.gameObject);
        }

        if (nesne.gameObject.tag == "Karakter")
        {
            SceneManager.LoadScene(0);
        }
        
    }
    
    void Start()
    {
        startpos1 = platform.transform.position;
       
    }

    
    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, startpos1, Time.deltaTime * speed);
        if(platform.transform.position == startpos1)
        {
            startpos1 = startpos2;
            if (startpos1 == startpos2)
            {
                startpos2 = platform.transform.position;
            }
        }
    }
}
