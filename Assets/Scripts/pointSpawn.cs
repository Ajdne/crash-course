using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSpawn : MonoBehaviour
{
    int racq = 0;   //GLUPOST
    float xPos;
    float zPos;
    float pointTimer = 5.0f;

    public GameObject thePoint;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PointSpawn());
    }
    IEnumerator PointSpawn()
    {    
        while (racq == 0) // treba mi bolju uslov od ovoga
        {            
            xPos = Random.Range(-29.5f, 29.5f);
            zPos = Random.Range(-59.5f, 59.5f);
            Instantiate(thePoint, new Vector3(xPos, 0.6f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(pointTimer);
            
            //availablePoints += 1;
            //pointTimer *= 0.9999f;     // doing this to reduce point spawn time and speed up the game
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
