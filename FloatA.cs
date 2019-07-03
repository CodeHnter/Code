using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class FloatA : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FloatAnimation();
    }
    public void FloatAnimation()
    {

        this.GetComponent<Animator>().Play("FloatAnimation", 0, 0.0f);
    }

}
