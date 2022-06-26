using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 5f;
    private Vector3 Move = new Vector3(0f, 0f, 0f);
    private Vector3 Rotate = new Vector3(0f, 0f, 0f);
    private Vector3 moveRotate = new Vector3(0f, 0f, 0f);

    // Update is called once per frame
    void Update()
    {
        Rotate = new Vector3(0f, 0f, 0f);
        Vector3 targetRotation = new Vector3(0f, 0f, 0f);
        switch (gameObject.tag)
        {
            case "EnemyMoveUp":
                Move = new Vector3(0f, 1f, 0f).normalized;
                targetRotation = new Vector3(0f, 0f, 180f);
                break;
            case "EnemyMoveDown":
                Move = new Vector3(0f, -1f, 0f).normalized;
                targetRotation = new Vector3(0f, 0f, 0f);
                break;
            case "EnemyMoveLeft":
                Move = new Vector3(-1f, 0f, 0f).normalized;
                targetRotation = new Vector3(0f, 0f, -90f);
                break;
            case "EnemyMoveRight":
                Move = new Vector3(1f, 0f, 0f).normalized;
                targetRotation = new Vector3(0f, 0f, 90f);
                break;
            case "EnemyRotateClockwise":
                Rotate = new Vector3(0f, 0f, -1f).normalized;
                break;
            case "EnemyRotateC-Clockwise":
                Rotate = new Vector3(0f, 0f, 1f).normalized;
                break;
        }

        transform.position += Move * Time.deltaTime * moveSpeed;
        transform.eulerAngles += Rotate * Time.deltaTime * rotateSpeed * 20;
        if(Move != Vector3.zero)
        {
            transform.eulerAngles = targetRotation;
        }
    }
}
