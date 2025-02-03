using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idolscript : MonoBehaviour

  

{
        public float destruct = 1;
           public float location = 31;
            public GameObject brickPrefab;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
         
    float location = transform.position.z;

        if (location > 31) {
           float destruct = 2;
           Invoke ("SpawnDelay",3);


        }
    if (location < 31) {
           float destruct = 2;

           Invoke ("SpawnDelay",3);

        }
  
    
    
    
    
    }
    private void SpawnDelay(){
        
      
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 5, Random.Range(-13, 31));
            Instantiate(brickPrefab, randomSpawnPosition, Quaternion.identity);


       }



}
