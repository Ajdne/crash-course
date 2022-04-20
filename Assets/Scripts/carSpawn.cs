using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour
{
    SimpleCarController movementScript;
    public GameObject theCarInvisible;
    public GameObject theCar;

    float newCurrentX;
    float newCurrentY;
    float newCurrentZ;

    public void spawnCar() {
        Instantiate(theCarInvisible,
            new Vector3(newCurrentX, newCurrentY, newCurrentZ), transform.rotation * Quaternion.Euler(0, 180, 0));
    }

    void Start()
    {
        movementScript = theCar.GetComponent<SimpleCarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    // can spawn additional cars for testing
        {
            Debug.Log("Space key was pressed.");
            Instantiate (theCar, new Vector3(0, 2, 0), Quaternion.identity);
        }

        newCurrentX = movementScript.currentX;
        newCurrentY = movementScript.currentY;
        newCurrentZ = movementScript.currentZ;
    }
}