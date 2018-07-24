using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class USB3 : MonoBehaviour {

    public bool rotate;
    public bool insert;
    public bool fin;

    public GameObject FinCable;
    public GameObject FailMenu;
    public GameObject menu;
    public GameObject usb;
    public GameObject Trigger;
    public GameObject NexTrigger;
    public GameObject Zoom;
    public GameObject Docs;

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
            Destroy(Trigger);
            NexTrigger.SetActive(true);
            FinCable.SetActive(true);
            usb.GetComponent<ObjectDrag>().enabled = true;
        }

        if(this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("USB3_w"))
        {
            Destroy(menu);
            FailMenu.SetActive(true);
            Zoom.GetComponent<Zoom>().zoomBool = false;
            Zoom.GetComponent<Image>().enabled = false;
            Docs.GetComponent<Image>().enabled = false;
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
