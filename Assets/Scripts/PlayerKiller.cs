using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public GameObject EndGameMenu;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EndGameMenu.SetActive(true);
            GameObject.Find("Enemy Ball").SetActive(false);
        }
    }
}
