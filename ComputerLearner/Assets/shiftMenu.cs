using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiftMenu : MonoBehaviour {

    public int shiftNum;
    public Animator menuAnim;
    public int largestNum;
    public int smallestNum;

    public GameObject backBtn;
    public GameObject fowardBtn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(shiftNum > largestNum)
        {
            shiftNum = largestNum;
        }

        if(shiftNum < smallestNum)
        {
            shiftNum = smallestNum;
        }

        if(shiftNum == largestNum)
        {
            fowardBtn.SetActive(false);
        }
        else
        {
            fowardBtn.SetActive(true);
        }

        if(shiftNum == smallestNum)
        {
            backBtn.SetActive(false);
        }
        else
        {
            backBtn.SetActive(true);
        }
	}

    public void Back()
    {
        shiftNum--;
        menuAnim.SetInteger("shift", shiftNum);
    }

    public void Foward()
    {
        shiftNum++;
        menuAnim.SetInteger("shift", shiftNum);
    }

    public void ResetShift()
    {
        shiftNum = 0;
    }
	public void Reset()
	{
        shiftNum = 0;
        menuAnim.SetInteger("shift", shiftNum);
	}
}
