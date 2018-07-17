using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caseAnim : MonoBehaviour
{
    public GameObject caseAnima;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Cont()
    {
        caseAnima.GetComponent<Animator>().SetBool("slide", true);
    }
}
