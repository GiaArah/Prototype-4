using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Detected") || other.gameObject.CompareTag("Player"))
        {
            other.tag = "Invisible";
            Debug.Log("Enter");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Invisible"))
        {
            other.tag = "Player";
            Debug.Log("Leave");
        }
    }
}
