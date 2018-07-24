using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourPin : MonoBehaviour {

    public bool rotate;
    public bool insert;

    public GameObject menu;
    public GameObject Trigger;
    public GameObject FinCable;
    public GameObject nex;
    public GameObject NexTrigger;
    public GameObject FailMenu;
    public GameObject Zoom;
    public GameObject Docs;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Animator>().SetBool("rotate", rotate);
        this.GetComponent<Animator>().SetBool("insert", insert);

        if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("4-pin_r"))
        {
            Destroy(menu);
            Destroy(this);
            Destroy(Trigger);
            NexTrigger.SetActive(true);
            FinCable.SetActive(true);
            nex.GetComponent<ObjectDrag>().enabled = true;
        }

        if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("4-pin_w"))
        {
            Destroy(menu);
            FailMenu.SetActive(true);
            Docs.GetComponent<Image>().enabled = false;
            Zoom.GetComponent<Image>().enabled = false;
            Zoom.GetComponent<Zoom>().zoomBool = false;
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
