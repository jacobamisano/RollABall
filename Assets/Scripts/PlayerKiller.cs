using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public GameObject EndGameMenu;
    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EndGameMenu.SetActive(true);
            ball.SetActive(false);
        }
    }
}
