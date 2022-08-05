using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class setActive : MonoBehaviour
{
    public GameObject nesne;
    public GameObject boya;
    public GameObject yazi;
    public GameObject button;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Temas");
        nesne.SetActive(true);
        boya.GetComponent<Renderer>().material.color = Color.red;
        Time.timeScale = 0;
        yazi.SetActive(true);
        button.SetActive(true);
        

    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
