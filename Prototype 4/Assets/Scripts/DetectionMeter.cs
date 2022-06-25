using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionMeter : MonoBehaviour
{
    private float detectionTrack = 0f;
    public float detectionModifier = 2.5f;
    public float detectionMax = 10f;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Detected"))
        {
            detectionTrack += Time.deltaTime * detectionModifier;
        }
        else if (detectionTrack >= 0f)
        {
            detectionTrack -= Time.deltaTime * detectionModifier;
        }
        else
        {
            detectionTrack = 0f;
        }
        Debug.Log(detectionTrack);
    }
}
