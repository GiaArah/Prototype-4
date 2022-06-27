using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public AudioSource footsteps;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        transform.position += move * Time.deltaTime * moveSpeed;
        if (move != Vector3.zero && !footsteps.isPlaying)
        {
            footsteps.Play();
        }
        if(transform.eulerAngles != Vector3.zero)
        {
            transform.eulerAngles = Vector3.zero;
        }
        if(transform.position.z != 0)
        {
            transform.position = new Vector3(currentPos.x,currentPos.y,0f);
            Debug.Log("reset height");
        }

        if(gameObject.CompareTag("Invisible"))
        {
            

        }
    }


}
