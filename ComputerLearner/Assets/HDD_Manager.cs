using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HDD_Manager : MonoBehaviour
{

    public GameObject HDD_Interative;
    public GameObject HDD_Static;
    public GameObject Menu;
    public GameObject FailedMenu;
    public GameObject mobo;
    public GameObject Stands;
    public Text Info;
    public bool Correct = false;

    private bool IScollide = false;
    private bool rotate;
    private bool insert;
    private bool menuActive;

	// Update is called once per frame
	void Update ()
    {
		if(IScollide == true)
        {
            HDD_Interative.SetActive(false);
            HDD_Static.SetActive(true);
            Info.text = "Orientate hard drive to case shelf";
            menuActive = true;

            if(insert == true)
            {
                menuActive = false;
            }
             
        }

        if(HDD_Static.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("wrong"))
        {
            FailedMenu.SetActive(true);
        }

        if (HDD_Static.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("right"))
        {
            Correct = true;
        }

        Menu.SetActive(menuActive);

        HDD_Static.GetComponent<Animator>().SetBool("rotate", rotate);
        HDD_Static.GetComponent<Animator>().SetBool("insert", insert);

        if(Correct == true)
        {
            mobo.GetComponent<ObjectDrag>().enabled = true;
            Info.text = ("Move mother board to case");

            if(Stands.GetComponent<MoboManager>().fin == true)
            {
                Info.text = "Move screwdriver to case";
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hdd")
        {
            IScollide = true;
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
}
