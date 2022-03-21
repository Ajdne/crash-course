using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour
{
    carMovement movementScript;
    public GameObject theCar;
    public void spawnCar() {
        Instantiate(theCar,
            new Vector3( movementScript.currentX,
                        movementScript.currentY, 
                        movementScript.currentZ),
                        transform.rotation * Quaternion.Euler(0, 180, 0));

    }
    void Start()
    {
        movementScript = theCar.GetComponent<carMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
