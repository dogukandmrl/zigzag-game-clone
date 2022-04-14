using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatformSpawner : MonoBehaviour
{
    public GameObject lastPlatform;

    void Start()
    {
        for(int i = 0; i<15; i++)
        {
            platfromCreate();
        }
    }
    
    public void platfromCreate()
    {
        Vector3 direction;
        if(Random.Range(0,2)== 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
       lastPlatform = Instantiate(lastPlatform, lastPlatform.transform.position + direction, lastPlatform.transform.rotation);
    }
 
}
