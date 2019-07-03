using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{
    static Animator anim;
    public float speed = 10.0f;
    public float rotationspeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float traslation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;
        traslation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0,0,traslation);
        transform.Rotate(0,rotation,0);
        if (Input.GetButtonDown("Jump")) {
            anim.SetTrigger("isJumping");


        }

    }
}
