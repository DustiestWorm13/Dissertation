using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionExit : MonoBehaviour
{
    public Canvas OptionExit1;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("hit option 1");
        OptionExit1.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("out option 1");
        OptionExit1.gameObject.SetActive(false);
    }
}
