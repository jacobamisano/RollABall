using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem.Sample;
using UnityEngine.InputSystem.LowLevel;
using Valve.VR.InteractionSystem;
using System.Linq;

public class idolscript : MonoBehaviour
{
    public float destruct = 1;
    public float location = 31;
    public GameObject brickPrefab;
    public GameObject[] enableContainer;
    public GameObject[] disableContainer;

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

    private void OnAttachedToHand(Hand hand)
    {
        startGameSequence();
        Debug.Log("I touched the thing!");
    }
    private void startGameSequence()
    {

        Debug.Log("Enable count:" + enableContainer.Count<GameObject>());
        foreach (GameObject gameObj in enableContainer) {
            Debug.Log("Enabling: " + gameObj);
            gameObj.SetActive(true);
        }
        foreach (GameObject gameObj in disableContainer)
        {
            gameObj.SetActive(false);
        }
    }

    private void SpawnDelay(){
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 5, Random.Range(-13, 31));
        Instantiate(brickPrefab, randomSpawnPosition, Quaternion.identity);
    }
}
