using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Optiontoilet : MonoBehaviour
{
    public Canvas toiletBreak;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("hit option 1");
        toiletBreak.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("out option 1");
        toiletBreak.gameObject.SetActive(false);
    }
}
