using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;    
    public float speed = 10;
    public float turnSpeed = 100;

    public float currentX;
    public float currentY;
    public float currentZ;
    float rotationX;
    Quaternion rotation;

    // Update is called once per frame
    void FixedUpdate()
    {
        float turn = Input.GetAxisRaw("Horizontal");

        rotationX = rotation.x;
        
        // Constantly moving forward if not flipped



        // ODRADITI MODEL AUTA ISPOCETKA !!!!!!!!!!!!!!!!!


            // Car moving forward
            frontLeft.motorTorque = speed * 1;
            frontRight.motorTorque = speed * 1;

            //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.Self);
            Debug.Log(rotation.x);

            // Turning of a car
            transform.Rotate(new Vector3(0, turn * turnSpeed * Time.deltaTime, 0));

            currentX = transform.position.x;
            currentY = transform.position.y;
            currentZ = transform.position.z;

        // Destory the car if it falls from the plane
        if (currentY < -10) {   
            Destroy(this.gameObject);
        }

    }

    void Start() {
        //rotation = Quaternion.this.gameObject;
    }
}
