using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSpawn : MonoBehaviour
{
    float xPos;
    float zPos;
    int pointTimer = 10;

    public GameObject thePoint;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PointSpawn());
    }

    IEnumerator PointSpawn()
    {
        while (true) //(racq == 10)      // treba mi bolju uslov od ovoga
        {            
            xPos = Random.Range(-25.5f, 25.5f);
            zPos = Random.Range(-49.5f, 49.5f);
            Instantiate(thePoint, new Vector3(xPos, 0.6f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(pointTimer);
            // availablePoints += 1;
            //pointTimer *= 0.9999f;     // doing this to reduce point spawn time and speed up the game
        } 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
