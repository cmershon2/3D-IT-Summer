
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {

    public GameObject arrow0;

    public GameObject Cube;
    public Text info;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(arrow0.GetComponent<menuColor>().fin == true)
        {
            Cube.GetComponent<ObjectDrag>().enabled = true;
            this.gameObject.SetActive(false);
            info.text = "Stack cubes as seen in video";
        }
	}
}
