﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseY : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= mouseY ;
        transform.localEulerAngles = newRotation;
    }
}
