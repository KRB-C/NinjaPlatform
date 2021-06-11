using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Vector3 startPosition;
    public float speed;
    public  static float currentSpeed;
    public float cSpeed;
    private Rigidbody rb;
    private float maxSpeed = 2.2f;
    private bool targetSpeed = false;
    private float newPosition;
    

    private void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        
    }

  

    void FixedUpdate()
    {
        if (Countdown.timeleft < 0)
        {

            if (newPosition < maxSpeed && !targetSpeed)
            {
                newPosition = Time.time * speed;
            }

            if (newPosition >= maxSpeed || targetSpeed)
            {
                newPosition = maxSpeed;
                targetSpeed = true;
            }
            currentSpeed = newPosition;
            cSpeed = newPosition;
            rb.velocity = new Vector3(0, newPosition, 0);
        }
        

    }


}
