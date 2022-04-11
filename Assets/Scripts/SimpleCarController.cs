using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}

public class SimpleCarController : MonoBehaviour {
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have


    // part of code from carMovement script
    public float currentX;
    public float currentY;
    public float currentZ;
    public float turnSpeed = 2;
    public float speed = 3;
    // *************************************

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * 1; //Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        
        // trying to avoid getting stuck into objects. Now the car can always rotate, no matter the wheels
        transform.Rotate(new Vector3(0, steering * turnSpeed * Time.deltaTime, 0));

        foreach (AxleInfo axleInfo in axleInfos) {

            if (axleInfo.steering) {                     // Steering part
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }

            if (axleInfo.motor) {                    // Acceleration
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }

            // THIS NEED FIXIN'
            if ( motor > maxMotorTorque * 0.5) {    
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);
            }
        }

        currentX = transform.position.x;
        currentY = transform.position.y;
        currentZ = transform.position.z;

        // part of code from carMovement script
        // Destory the car if it falls from the plane
        if (currentY < -10) {   
            Destroy(this.gameObject);
        }
        //***************************************************
    }
}