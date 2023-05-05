using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 25.0f; // The max distance the object travels forward before being destroyed
    public float bottomBound = -10.0f; //The max dist the animals travel before despawning

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < bottomBound) {
            Destroy(gameObject);
        }
    }
}
