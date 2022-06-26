using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Invisible") == false)
        {
            Debug.Log("Tag");
            player.tag = "Detected";
        }
    }

    void OnTriggerExit (Collider other)
    {
        Debug.Log("Left");
        if (other.gameObject.CompareTag("Invisible") == false)
        {
            player.tag = "Player";
            Debug.Log("Untag");
        }
    }
}
