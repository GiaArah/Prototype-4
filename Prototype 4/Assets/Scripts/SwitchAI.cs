using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAI : MonoBehaviour
{
    public string searchTag;
    public string changeTag;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(searchTag))
        {
            other.tag = changeTag;
        }
    }
}
