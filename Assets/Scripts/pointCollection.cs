using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollection : MonoBehaviour
{
    carSpawn carSpawnScript;
    public GameObject theCar;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Point"))
        {
            print("Point collected!");
            Destroy(other.gameObject); // destroy the point

            carSpawnScript.spawnCar();
        }
    }
    void Start() {
        carSpawnScript = theCar.GetComponent<carSpawn>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
