using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    float turn;

    float currentX;
    float currentY;
    float currentZ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // left/right input keys
        float turn = Input.GetAxisRaw("Horizontal");

        // Car moving forward
        transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0), Space.Self);
        
        // Turning of a car
        transform.Rotate(new Vector3(0, turn * turnSpeed * Time.deltaTime, 0));

        currentX = transform.position.x;
        currentY = transform.position.y;
        currentZ = transform.position.z;

        if (currentY < -10) {   
            Destroy(this.gameObject);
        } 
    }
}
