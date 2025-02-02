using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject PickupParent;
    public GameObject MusicPlayer;

    //LIV'S
    public AudioClip DingClip;
    public AudioClip WinClip;
    public AudioClip LoseClip;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);

    }


    void OnMove(InputValue movementValue)
    {

        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;


    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            //LIV'S pickup clip player
            AudioSource.PlayClipAtPoint(DingClip, new Vector3(0, 1, 0));
        }

        if (count >= PickupParent.transform.childCount + 1)
        {

            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            //LIV'S win clip player
            Destroy(GameObject.FindGameObjectWithTag("Music"));
            AudioSource.PlayClipAtPoint(WinClip, new Vector3(0, 1, 0));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Update the winText to display "You Lose!"
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "L BOZO";
            // Destroy the current object
            gameObject.SetActive(false);
            Destroy(GameObject.FindGameObjectWithTag("Music"));
            AudioSource.PlayClipAtPoint(LoseClip, new Vector3(0, 1, 0));

        }
    }
}
