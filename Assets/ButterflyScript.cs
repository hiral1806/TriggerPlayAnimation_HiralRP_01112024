using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButterflyScript : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
    }
}