using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewCollider : MonoBehaviour {

    public Animator anim;
    public GameObject Butt;
    public bool fin = false;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(anim.GetCurrentAnimatorStateInfo(0).IsName("finIdle"))
        {
            fin = true;
        }
	}
    

    public void ScrewButton ()
    {
        anim.SetBool("screw", true);
        Butt.SetActive(false);
    }
}
