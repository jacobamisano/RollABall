using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float destruct = 1;
    void Update()
    {
       
    
    
    
    Invoke ("SpawnDelay",3);

     





    }
       private void SpawnDelay(){
        
        if(destruct > 2);
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 5, Random.Range(-13, 31));
            Instantiate(brickPrefab, randomSpawnPosition, Quaternion.identity);


        }
       }



}
