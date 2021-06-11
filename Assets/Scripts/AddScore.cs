using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour {

    private bool pointsTaken = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (pointsTaken == false)
        {
            if (other.gameObject.tag == "Player")
            {
                GameController.instance.UpdateScore();
                pointsTaken = true;
            }
        }
    }

}
