using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    GameObject playerobj;
    Vector3 cameraOffset;
    // Use this for initialization
    void Start () {
        playerobj = GameObject.Find("sylvanas_fbx");
        cameraOffset = new Vector3(-10, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = playerobj.transform.position + cameraOffset;
    }
}
