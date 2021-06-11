using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && SimplePlatformController.grounded == true)
        {
            Destroy(transform.parent.gameObject, 2.0f);
        }
    }
}
