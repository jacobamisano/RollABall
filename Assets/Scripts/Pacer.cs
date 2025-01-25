using UnityEngine;
using System.Collections;

public class Pacer : MonoBehaviour
{
    public float speed = 5.0f;
    public float zMax = 7.5f;
    public float zMin = -7.5f; //starting position
    
    private int direction = 1; //positive to start

    void Update() {
        float zNew = transform.position.z + direction* speed *Time.deltaTime;
        float xStart = transform.position.x;
        if (zNew >= zMax) {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew <= zMin) {
            zNew = zMin;
            direction *= -1;
        }
        transform.position = new Vector3(xStart, 0.75f, zNew);
    }
}