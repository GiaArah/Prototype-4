using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1f;



    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        transform.position += move * Time.deltaTime * moveSpeed;
    }
}
