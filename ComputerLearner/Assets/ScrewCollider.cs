using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewCollider : MonoBehaviour {

    public GameObject interact;
    public GameObject StaticDriver;
    public GameObject DynamicDriver;
    public Animator anim;
    public GameObject Butt;
    public bool collider = false;
    public bool fin = false;

	// Use this for initialization
	void Start ()
    {
        StaticDriver.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(anim.GetCurrentAnimatorStateInfo(0).IsName("finIdle"))
        {
            Destroy(StaticDriver);
            DynamicDriver.SetActive(true);
            this.GetComponent<BoxCollider>().enabled = false;
        }

        if(collider == true)
        {
            StaticDriver.SetActive(true);
            interact.SetActive(false);
        }
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "driver")
        {
            collider = true;
        }
    }

    public void ScrewButton ()
    {
        anim.SetBool("screw", true);
        Butt.SetActive(false);
    }
}
