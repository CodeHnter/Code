using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationS : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animation();
    }

    void Animation() {

        this.GetComponent<Animator>().Play("IntAnimation",0,0.0f);
       this.GetComponent<Animator>().Play("FloatAnimation",0,0.0f);
        this.GetComponent<Animator>().Play("StringAnimation", 0, 0.0f);
    }
}
