using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    //   public int shotDamage = 20;
    //   public float reloadTime = .2f;
    //   public float range = 50f;
    //   public GameObject weapon;

    //   private float timer;
    //   private Ray rayShot;
    //   private RaycastHit hit;
    //   private LineRenderer sline;
    //   private AudioSource sAudio;
    //   private Light slight;
    //   private float sEffect=.2f;

    //   private void Awake()
    //   {
    //       sline = GetComponent<LineRenderer>();
    //       sAudio = GetComponent<AudioSource>();
    //       slight = GetComponent<Light>();

    //   }
    //   // Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {
    //       timer += Time.deltaTime;
    //       if(Input.GetButton("Fire1")&& timer >= reloadTime)
    //       {
    //           if (weapon.activeInHierarchy)
    //           {
    //               Shoot(); 
    //           }

    //       }
    //       if (timer >= reloadTime * sEffect)
    //       {
    //          DisableEffect();
    //       }
    //}
    //   void Shoot()
    //   {
    //       //Reset Timer
    //       timer = 0f;
    //       //play firing audio
    //       sAudio.Play();
    //       //Enable muzzle light 
    //       slight.enabled = true;
    //       //Enable shooting line 
    //       sline.enabled = true;
    //       //Set the first point of the line at muzzle
    //       sline.SetPosition(0, transform.position);
    //       //Set the ray's originating point tomuzzle
    //       rayShot.origin = transform.position;
    //       //Set the direction of the ray to be away from muzzle 
    //       rayShot.direction = transform.forward;

    //       ////cast the ray and get info on what it hit 
    //       if (Physics.Raycast(rayShot, out hit, range/*shootable*/))
    //       {
    //           EnemyHealth enemyHealth;
    //           enemyHealth  = hit.collider.GetComponent<EnemyHealth>();
    //           if (enemyHealth != null)
    //           {
    //               enemyHealth.GetHurt(shotDamage);

    //           }
    //           sline.SetPosition(1, hit.point);

    //       }
    //       else{
    //           sline.SetPosition(1, rayShot.origin + range * rayShot.direction);

    //       }

    //   }
    //   void DisableEffect()
    //   {
    //       slight.enabled=false;

    //       sline.enabled = false;
    //   }
    public Transform t;
    
    void OnMouseDown()
    {
       // GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = t.position;
        this.transform.parent = GameObject.Find("destination").transform;

    }

  

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
       // GetComponent<BoxCollider>().enabled = true;

    }
}
