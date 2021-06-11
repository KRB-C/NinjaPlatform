using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float speed;
    public float newtime;

    // Use this for initialization
    void Awake()
    {
        newtime = Time.timeSinceLevelLoad - 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Countdown.timeleft < 0)
        {
            
                newtime = Time.timeSinceLevelLoad - 3f;
                Vector2 offset = new Vector2(0, newtime * speed);
                GetComponent<Renderer>().material.mainTextureOffset = offset;
                
            
           
        }
    }
}
