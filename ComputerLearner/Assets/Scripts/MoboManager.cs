using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoboManager : MonoBehaviour {

    public GameObject moboStatic;
    public GameObject moboAnimated;
    public GameObject mobo;
    public GameObject Screws;
    public GameObject HDD;
    public GameObject screwDriverInteractive;
    public GameObject[] screwDriverStatic;

    public GameObject DriverUI;
    public GameObject RotationUI;
    public GameObject FailUI;

    public bool rotate = false;
    public bool insert = false;
    public bool fin = false;

    private int screwID = 0;
    private bool driverFin = false;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        moboAnimated.GetComponent<Animator>().SetBool("rotate", rotate);
        moboAnimated.GetComponent<Animator>().SetBool("insert", insert);

        if(moboAnimated.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("wrong"))
        {
            FailUI.SetActive(true);
        }

        if (moboAnimated.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("right"))
        {
            Screws.SetActive(true);
            fin = true;
        }

        if(fin == true)
        {
            RotationUI.SetActive(false);
            screwDriverInteractive.GetComponent<ObjectDrag>().enabled = true;
        }

        for(int i = 0; i < screwDriverStatic.Length; i++)
        {

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CPU")
        {
            mobo.SetActive(false);
            moboAnimated.SetActive(true);
            RotationUI.SetActive(true);
        }

        if(collision.gameObject.tag == "driver")
        {
            screwID++;
            driverFin = true;
            screwDriverInteractive.SetActive(false);
        }
    }

    public void Rotate()
    {
        rotate = !rotate;
    }

    public void Insert()
    {
        insert = true;
    }

    public void Next()
    {
        screwID++;
    }
}
