using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USB3 : MonoBehaviour {

    public bool rotate;
    public bool insert;
    public bool fin;

    public GameObject FinCable;
    public GameObject menu;
    public GameObject usb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.GetComponent<Animator>().SetBool("rotate", rotate);
        this.GetComponent<Animator>().SetBool("insert", insert);

        if(this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("USB3_r"))
        {
            Destroy(menu);
            Destroy(this);
            FinCable.SetActive(true);
            usb.GetComponent<ObjectDrag>().enabled = true;
        }

        
    }

    public void rotateBtn()
    {
        rotate = !rotate;
    }

    public void insertBtn()
    {
        insert = true;
    }
}
