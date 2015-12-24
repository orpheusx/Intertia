﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Camera mycam;
	Vector3 zOffset = new Vector3(0,0,-10);

	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
		// Preserve relative sizing regardless of screen dimensions
		mycam.orthographicSize = (Screen.height / 100f) / 4f;

		if (target) {
			transform.position = Vector3.Lerp (
				transform.position, target.position, 
				0.1f) + zOffset;
		}


	}
}
