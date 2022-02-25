using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject Prefab;

    public int amountToSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < amountToSpawn; i++)
        {
            //create a random position to spawn at
            Vector3 pos = new Vector3(transform.position.x + Random.Range(-20f, 20f),
                transform.position.y, 
                transform.position.z + Random.Range(-20f, 20f));
            //spawn object at our location
            Instantiate(Prefab, pos, transform.rotation);
        }
        
       
    }

}