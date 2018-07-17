using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour {

    public GameObject enabled;
    public GameObject menu;
    public bool slap;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(slap == true)
        {
            
            if (menu != null)
                menu.SetActive(true);

            enabled.SetActive(true);
        }

		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "driver")
        {
            other.gameObject.SetActive(false);
            slap = true;
        }
    }
}
