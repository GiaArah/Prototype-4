using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Invisible") == false && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Tag");
            other.tag = "Detected";
        }
    }

    void OnTriggerExit (Collider other)
    {
        Debug.Log("Left");
        if (other.gameObject.CompareTag("Invisible") == false && other.gameObject.CompareTag("Detected"))
        {
            other.tag = "Player";
            Debug.Log("Untag");
        }
    }
}
