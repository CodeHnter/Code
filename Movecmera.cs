using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecmera : MonoBehaviour {
    GameObject playerobj;
    Vector3 cameraOffset;
    // Use this for initialization
    void Start () {
        playerobj = GameObject.Find("Walk_look around_v04");
        cameraOffset = new Vector3(-5.95f, 1.6f, 2.773803f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = playerobj.transform.position + cameraOffset;
    }
}
