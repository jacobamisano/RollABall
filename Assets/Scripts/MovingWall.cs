using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class MovingWall: MonoBehaviour
{
    public float speed = .25f;
    public float yMin = 0f;
    private int wallDirection = 1; //positive to start
    
    void Update()
    {
        float yNew = transform.position.y - (wallDirection * speed * Time.deltaTime);
        if (yNew <= yMin)
        {
            yNew = yMin;
        }
        if (transform.position.y >= yMin)
        {
            transform.position = new Vector3(transform.position.x, yNew, transform.position.z);
        }
    }
}