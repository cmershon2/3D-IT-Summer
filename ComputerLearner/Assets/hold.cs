using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hold : MonoBehaviour {

    public GameObject Drag;
    public GameObject Cable;

    // Use this for initialization
    void Start()
    {
        if(Drag == null)
            Drag = this.gameObject;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Drag.GetComponent<ObjectDrag>().hold == true && Drag.GetComponent<ObjectDrag>().enabled == true)
        {
            //Drag.GetComponent<BoxCollider>().enabled = false;
            Cable.SetActive(false);
            Destroy(this.GetComponent<EventTrigger>());
        }
        else
        {
            Drag.GetComponent<BoxCollider>().enabled = true;
        }
	}
}
