using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option2 : MonoBehaviour
{
    public Canvas Option02;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("hit option 2");
        Option02.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("out option 2");
        Option02.gameObject.SetActive(false);
    }
}
