using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotationColor : MonoBehaviour {

    public GameObject Player;
    public bool right;
    public bool left;
    public bool fin;
    public Color finalColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(right == true)
        {
            if(Player.GetComponent<CamRotate>().TurnRight == false)
            {
                this.GetComponent<Image>().color = finalColor;
                fin = true;
            }
        }

        if (left == true)
        {
            if (Player.GetComponent<CamRotate>().TurnLeft == false)
            {
                this.GetComponent<Image>().color = finalColor;
                fin = true;
            }
        }
    }
}
