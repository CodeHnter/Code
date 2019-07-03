using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class String : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StringAnimation();
        

    }
  public  void StringAnimation()
    {

        this.GetComponent<Animator>().Play("StringAnimation", 0, 0.0f);

    }
}
