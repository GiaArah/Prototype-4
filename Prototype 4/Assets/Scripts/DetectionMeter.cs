using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionMeter : MonoBehaviour
{
    private float detectionTrack = 0f;
    public float detectionModifier = 2.5f;
    public float detectionMax = 10f;


    public GameObject meterSprite;
    private float scaleMath;
    private float posMath;
    private Vector3 scaleChange;
    private Vector3 posChange;

    void Start()
    {
        scaleMath = 0.9f / (detectionMax / detectionModifier);
        posMath = scaleMath / 2f;
        scaleChange = new Vector3(scaleMath, 0f, 0f);
        posChange = new Vector3(posMath, 0f, 0f);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(detectionTrack);
        Vector3 tempScale = meterSprite.transform.localScale;
        Vector3 tempPos = meterSprite.transform.position;
        if (gameObject.CompareTag("Detected"))
        {

            if(tempScale.x < 0.9f)
            {
                detectionTrack += Time.deltaTime * detectionModifier;
                tempScale += scaleChange * Time.deltaTime;
                tempPos += posChange * Time.deltaTime;
                meterSprite.transform.localScale = tempScale;
                meterSprite.transform.position = tempPos;
                //Debug.Log("Going up");
            }
        }
        else
        {
            if (detectionTrack > 0)
            {
                detectionTrack -= Time.deltaTime * detectionModifier;

                if (tempScale.x > 0f)
                {
                    tempScale -= scaleChange * Time.deltaTime;
                    tempPos -= posChange * Time.deltaTime;
                    meterSprite.transform.localScale = tempScale;
                    meterSprite.transform.position = tempPos;
                    //Debug.Log("Going down");
                    //Debug.Log(tempPos);
                }

                                //Tried to make some code that would catch the detection track and keep it from going below 0, this did not work. 
                /*else
                {
                    tempScale.x = 0f;
                    tempPos.x = 0f;
                    meterSprite.transform.localScale = tempScale;
                    meterSprite.transform.position = tempPos;
                    Debug.Log("Staying Down");
                    Debug.Log(tempPos);
                }
            }
            else
            {
                detectionTrack = 0f;
                tempScale.x = 0f;
                tempPos.x = 0.454f;
                meterSprite.transform.localScale = tempScale;
                meterSprite.transform.position = tempPos;
                Debug.Log("Staying Down");
                Debug.Log(tempPos);*/
            }
        }
    }
}
