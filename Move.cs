using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    private CharacterController Controller;
    [SerializeField]
    private float Speed = 3.5f;
        private float gravity = 8.18f;
    //public bool pickitem = false;
    // Use this for initialization
    void Start () {
        Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}
    void Movement() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, VerticalInput);
        Vector3 velocity = direction * Speed;
        velocity.y -= gravity;
        Controller.Move(velocity * Time.deltaTime);
    }
}
