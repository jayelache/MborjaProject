using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour {

    GameObject player;
    public GameObject linkedHole;

	void Start () {
        player = GameObject.Find("Player Controller");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = new Vector2(((linkedHole.transform.position.x) + 2), linkedHole.transform.position.y);

    }
}
