using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    float speed = 10;
    float turnSpeed = 100;

    public float currentX;
    public float currentY;
    public float currentZ;
    Quaternion rotation;
    //Quaternion startRotation;

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxisRaw("Horizontal");

        //rotationX = transform.rotation.x;
        
        // Constantly moving forward if not flipped
        if (rotation.eulerAngles.x < 60f && rotation.eulerAngles.x > -60f)  {
            // Car moving forward
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.Self);
            
            // Turning of a car
            transform.Rotate(new Vector3(0, turn * turnSpeed * Time.deltaTime, 0));
        }
            

            currentX = transform.position.x;
            currentY = transform.position.y;
            currentZ = transform.position.z;

        // Destory the car if it falls from the plane
        if (currentY < -10) {   
            Destroy(this.gameObject);
        }

    }

    void Start() {
        rotation = Quaternion.identity;
    }
}
