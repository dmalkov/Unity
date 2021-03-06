﻿using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Camera camera = GetComponentInChildren<Camera> ();
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;

		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;

	}
}