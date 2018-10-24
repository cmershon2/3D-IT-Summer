using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnClick : MonoBehaviour {

    public GameObject killMe;

    public void OnClick()
    {
        Destroy(killMe);
    }
}
