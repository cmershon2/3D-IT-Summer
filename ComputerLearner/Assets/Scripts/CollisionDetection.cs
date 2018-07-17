using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public Transform ObjSpawnPoint;

    // Use this for initialization
    void Start()
    {
        if(ObjSpawnPoint == null)
        {
            Debug.Log("Assign Object Respawn Point.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            this.transform.position = ObjSpawnPoint.position;
        }           
    }
}