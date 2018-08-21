using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuColor : MonoBehaviour {

    public GameObject menuOBJ;
    public Color finalColor;
    public bool fin;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(menuOBJ.activeSelf == true)
        {
            this.GetComponent<Image>().color = finalColor;
            fin = true;
        }
	}
}
