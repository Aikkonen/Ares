﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Camera cam = Camera.main;
        cam.transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
	}
}
