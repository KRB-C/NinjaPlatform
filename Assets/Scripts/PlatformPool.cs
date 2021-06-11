using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject spawnPoint;
   
    public float minX = -1f;
    public float maxX = 3.5f;
    public float spawnSeconds = 1.8f;

    private float spawnYPosition;
 
	// Use this for initialization
	void Start () {
        StartCoroutine(spawnPlatform());
	}
	
	// Update is called once per frame
	IEnumerator spawnPlatform () {
       
        while (true)
        {
                                   

            spawnYPosition = spawnPoint.transform.position.y;
            Vector2 spawnPosition = new Vector2(Random.Range(minX, maxX), spawnYPosition);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnSeconds);
            
        }
	}
}
