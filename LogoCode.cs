using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogoCode : MonoBehaviour {
    public Image Logo;
    public string Manu;
    IEnumerator Start() {
        Logo.canvasRenderer.SetAlpha(0.0f);
        Fadein();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(Manu);


    }
   void Fadein()
    {
        Logo.CrossFadeAlpha(1.0f,2.5f,false);
    }

    void FadeOut() {
        Logo.CrossFadeAlpha(0.0f, 2.5f, false);
    }

}
