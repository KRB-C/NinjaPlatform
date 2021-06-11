using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameController : MonoBehaviour {

    public static GameController instance;
    
    public Text scoreText;
    public Text loseText;

    private int score;
    public bool isDead = false;
    

    public AudioClip DeadSong;
    public AudioClip JumpSong;
    private AudioSource  audio;
    
    
    

	// Use this for initialization
	void Start () {
        Screen.SetResolution(600, 900, true);
        scoreText.text = "Score: 0";
        loseText.enabled = false;
        audio = GetComponent<AudioSource>();
        audio.clip = JumpSong;
        audio.Play();
        audio.ignoreListenerPause = true;
    }
	
	// Update is called once per frame
	void Update () {

        

        if (isDead == true)
        {
            loseText.text = "Game Over!";
            loseText.enabled = true;
            audio.Pause();
            audio.clip = DeadSong;
            audio.Play();
            
            
        }
        
	}

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

            Time.timeScale = 1;
            isDead = false;
        
        
    }

    public void UpdateScore()
    {
        score += 5;
        scoreText.text = "Score: " + score;
    }

    
}
