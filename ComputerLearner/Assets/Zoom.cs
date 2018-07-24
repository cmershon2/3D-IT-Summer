using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

    public GameObject Player;
    public GameObject Document;
    public GameObject MainOrigin;
    public GameObject CaseCam;
    public GameObject CaseCamPSU;
    public GameObject exitZoom;
    public bool zoomBool;
    public bool psuBool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(zoomBool == true)
        {
            exitZoom.SetActive(true);
            if (psuBool == true)
            {
                Player.transform.position = CaseCamPSU.transform.position;
                
                Document.SetActive(false);
            }
            else
            {
                Player.transform.position = CaseCam.transform.position;
                Document.SetActive(false);
            }
        }
        else if(zoomBool == false)
        {
            exitZoom.SetActive(false);
            Player.transform.position = MainOrigin.transform.position;
            Document.SetActive(true);
        }
	}

    public void ZoomBtn()
    {
        zoomBool = !zoomBool;
    }
}
