using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp2Anim : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.GetComponent<Animator>().Play("Anim(E)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(VV)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(==)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(intt)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(;;)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(+)", 0, 0.0f);
    }
	
}
