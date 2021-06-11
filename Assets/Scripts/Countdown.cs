using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public static float timeleft = 3f;
    public Text Countdowntext;

    // Use this for initialization


    private void Awake()
    {
        timeleft = 3f;
    }
    void Update()
    {
        

            timeleft -= Time.deltaTime;
            Countdowntext.text = "Starting in " + Mathf.Round(timeleft);
            
          
        if(timeleft < 0)
        Countdowntext.text = "";
    }
}
