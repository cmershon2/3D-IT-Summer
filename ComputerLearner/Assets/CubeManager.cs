using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    public GameObject NextTrigger;
    public GameObject NextObject;
    public GameObject StaticCube;
    public GameObject DynamicCube;
    public GameObject FinalMenu;

    private bool collided;
    private bool collidedFIN;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(collided == true)
        {
            DynamicCube.SetActive(false);
            StaticCube.SetActive(true);
            this.GetComponent<BoxCollider>().enabled = false;
            NextTrigger.SetActive(true);
            NextObject.GetComponent<ObjectDrag>().enabled = true;
        }

        if(collidedFIN == true)
        {
            DynamicCube.SetActive(false);
            StaticCube.SetActive(true);
            FinalMenu.SetActive(true);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hdd")
        {
            collided = true;
        }

        if (other.tag == "driver")
        {
            collidedFIN = true;
        }
    }
}
