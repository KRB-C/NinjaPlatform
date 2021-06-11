using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBoundary : MonoBehaviour {


  

    private void Update()
    {
        // X axis
        if (transform.position.x <= -5.5f)
        {
            transform.position = new Vector2(-5.5f, transform.position.y);
        }
        else if (transform.position.x >= 5.5f)
        {
            transform.position = new Vector2(5.5f, transform.position.y);
        }
    }
}
