using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationManager : MonoBehaviour {

    public GameObject arrow0;
    public GameObject arrow1;

    public GameObject Tutorial1;
    public GameObject MenuOBJ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        if(arrow0.GetComponent<rotationColor>().fin == true && arrow1.GetComponent<rotationColor>().fin == true)
        {
            Tutorial1.SetActive(true);
            MenuOBJ.SetActive(true);
            this.gameObject.SetActive(false);
        }

	}
}
