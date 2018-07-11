using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public Transform Screw;

    void Update()
    {
        Vector3 targetPostition = new Vector3(target.position.x,
                                       Screw.position.y,
                                       Screw.position.z);

        this.transform.LookAt(targetPostition);
    }
}
