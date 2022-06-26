using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionMeter : MonoBehaviour
{
    private float detectionTrack = 0f;
    public float detectionModifier = 2.5f;
    public float detectionMax = 10f;
    public GameObject meterSprite;
    private Vector3 scaleChange = new Vector3 (0.09f, 0f, 0f);
    private Vector3 posChange = new Vector3 (0.045f, 0f, 0f);


    // Update is called once per frame
    void Update()
    {
        Vector3 tempScale = meterSprite.transform.localScale;
        Vector3 tempPos = meterSprite.transform.position;
        if (gameObject.CompareTag("Detected"))
        {
            detectionTrack += Time.deltaTime * detectionModifier;
            if(tempScale.x < 0.9f)
            {
                tempScale += scaleChange * Time.deltaTime;
                tempPos += posChange * Time.deltaTime;
                meterSprite.transform.localScale = tempScale;
                meterSprite.transform.position = tempPos;
            }
        }
        else if (detectionTrack >= 0f)
        {
            detectionTrack -= Time.deltaTime * detectionModifier;

            if (tempScale.x != 0f)
            {
                tempScale -= scaleChange * Time.deltaTime;
                tempPos -= posChange * Time.deltaTime;
                meterSprite.transform.localScale = tempScale;
                meterSprite.transform.position = tempPos;
            }
        }
        else
        {
            detectionTrack = 0f;
            tempScale.x = 0f;
            meterSprite.transform.localScale = tempScale;
            meterSprite.transform.position = tempPos;
        }
    }
}
