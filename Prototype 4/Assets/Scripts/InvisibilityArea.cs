using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityArea : MonoBehaviour
{

    public GameObject player;

    public AudioSource whoosh;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Detected") || other.gameObject.CompareTag("Player"))
        {
            other.tag = "Invisible";
            Debug.Log("Enter");
            PlayWhoosh();
            // pt.SetT(0.8f);
            player.GetComponent<Renderer>().material.color = new Color(0.78f, 0.47f, 0.53f, 0.31f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Invisible"))
        {
            other.tag = "Player";
            Debug.Log("Leave");
            // pt.SetT(1.0f);
            player.GetComponent<Renderer>().material.color = new Color(0.78f, 0.47f, 0.53f, 1);
        }
    }

    void PlayWhoosh()
    {
        if(!whoosh.isPlaying)
        {
            whoosh.Play();
        }
    }
}
