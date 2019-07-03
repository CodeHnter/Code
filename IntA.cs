using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class IntA : MonoBehaviour {

	// Use this for initialization
	void Start () {
        IntAnimation();

    }

    public void IntAnimation() {
        this.GetComponent<Animator>().Play("IntAnimation", 0, 0.0f);

    }
}
