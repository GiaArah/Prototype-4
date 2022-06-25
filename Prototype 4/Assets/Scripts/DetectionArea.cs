using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        if (!player.CompareTag("Invisible"))
        {
            player.tag = "Detected";
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (!player.CompareTag("Invisible"))
        {
            player.tag = "Untagged";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
