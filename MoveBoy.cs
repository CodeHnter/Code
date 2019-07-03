using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoy : MonoBehaviour {

    private Animator Anim;
    private CharacterController Controller;
    private Vector3 movDirction;

    public float speed = 6.0f;
    public float turbSpeed = 60.0f;
    public float gravity = 20.0f;
    public bool pickitem =false;

    

    // Use this for initialization
    void Start () {
             //Anim = gameObject.GetComponentInChildren<Animator>();
        Controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
         GetInput();
        
    }

    /* void GetInput()
     {

         //run
         if (Input.GetKey(KeyCode.UpArrow))
         {
              Anim.SetInteger("AnimPar",1);
         }
         else
         {
             Anim.SetInteger("AnimPar", 0);

         }
         //jaump
         if (Input.GetKey(KeyCode.Space))
         {

             Anim.SetInteger("jumpInt", 1);
         }
         else
         {
             Anim.SetInteger("jumpInt", 0);

         }
         //crouchInt
         if (Input.GetKey(KeyCode.C))
         {
             Anim.SetInteger("crouchInt", 1);
         }
         else
         {
             Anim.SetInteger("crouchInt", 0);

         }
         //LeftArrow
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             Anim.SetInteger("Left", 1);
         }
         else
         {
             Anim.SetInteger("Left", 0);

         }
         //RightArrow
         if (Input.GetKey(KeyCode.RightArrow))
         {
             Anim.SetInteger("Right", 1);
         }
         else
         {
             Anim.SetInteger("Right", 0);

         }
         */

    ///
    //Move Character ////
    ///
    void GetInput() {
        float delta = 0.01f;
        movDirction = Vector3.zero;
        if (Input.GetAxis("Vertical") < delta || Input.GetAxis("Vertical") > -delta)
        {
            movDirction.y = 0;
            movDirction = transform.forward * Input.GetAxis("Vertical") * speed;

        } }

        ///Rotation Character
        //float turn = Input.GetAxis("Horizontal");
        //transform.Rotate(0, turn * turbSpeed * Time.deltaTime, 0);
        //Controller.Move(movDirction * Time.deltaTime);
        // movDirction.y -= gravity * Time.deltaTime;





    
}
