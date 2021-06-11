using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScroll : MonoBehaviour {

    private Vector3 startPosition;
    public float speed;
    public float currentSpeed;
    private Rigidbody rb;
    private float maxSpeed = 1.8f;
    private float newPosition;

    private void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();

    }



    void FixedUpdate()
    {
       
            newPosition = speed;

        currentSpeed = newPosition;
        
        rb.velocity = new Vector3(0, newPosition, 0);



    }
}
