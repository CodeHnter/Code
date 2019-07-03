using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epx1Anim : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Animator>().Play("Anim(15)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(V)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(=)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(int)", 0, 0.0f);
        this.GetComponent<Animator>().Play("Anim(;)", 0, 0.0f);
    }
	
}
