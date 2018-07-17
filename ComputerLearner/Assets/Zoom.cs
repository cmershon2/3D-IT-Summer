using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

    public GameObject Player;
    public GameObject Document;
    public GameObject MainOrigin;
    public GameObject CaseCam;
    public GameObject USB3;
    public bool zoomBool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(zoomBool == true)
        {
            Player.transform.position = CaseCam.transform.position;
            Document.SetActive(false);
        }
        else if(zoomBool == false)
        {
            Player.transform.position = MainOrigin.transform.position;
            Document.SetActive(true);
        }
	}

    public void ZoomBtn()
    {
        zoomBool = !zoomBool;
    }
}
