using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    float speed = 5;
    float turnSpeed = 100;

    public float currentX;
    public float currentY;
    public float currentZ;
    

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxisRaw("Horizontal");

        // Constantly moving forward
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.Self);
        // Turning of a car
        transform.Rotate(new Vector3(0, turn * turnSpeed * Time.deltaTime, 0));

        currentX = transform.position.x;
        currentY = transform.position.y;
        currentZ = transform.position.z;
    }
}
