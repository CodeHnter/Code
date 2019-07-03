using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject Randomx;
    public GameObject Randomy;
    public GameObject Randomz;
    public GameObject Random19;
    public GameObject Randoma;
    public GameObject Randomd;
   public GameObject Random64;
    public GameObject Randomb;
    public GameObject Randomf;
    public GameObject Random84;


    // Use this for initialization
    void Start () {
        StartCoroutine(RespawnRoutine());
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    IEnumerator RespawnRoutine() {
        
        Instantiate(Randomx, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randomy, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randomz, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randoma, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randomb, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
       Instantiate(Random19, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randomd, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Random64, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Randomf, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        Instantiate(Random84, new Vector3(Random.Range(-60f, 60f), -3f, Random.Range(-60f, 60f)), Quaternion.identity);
        yield return new WaitForSeconds(5.0f);
    }
}
