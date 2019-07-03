using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LearingCode : MonoBehaviour {



    IEnumerator Start()
    {

        yield return new WaitForSeconds(30f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
