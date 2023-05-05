using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xInput; 
    public float moveSpeed = 10.0f;
    public float xRange = 15.0f; // the Max distance the player move within in the scene

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange) { // If the player is out of bounds on the left side
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) { // If the player is out of bounds on the right side
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        xInput = Input.GetAxis("Horizontal"); // Left & Right keys + A & D Keys

        transform.Translate(Vector3.right * xInput * Time.deltaTime * moveSpeed); 
    }
}
