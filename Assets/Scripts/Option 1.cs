using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option1 : MonoBehaviour
{
    public Canvas Option01;
    
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("hit option 1");
        Option01.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("out option 1");
        Option01.gameObject.SetActive(false);
    }
   

        

}
