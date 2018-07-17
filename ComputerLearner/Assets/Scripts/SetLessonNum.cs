using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLessonNum : MonoBehaviour {
     public GameObject PlayerData;
     public int lesson;
     
     public void Update() {
        if(PlayerData == null)
        {
            PlayerData = GameObject.Find("PlayerData");
        }
     }
     
     public void OnClick() {
        PlayerData.GetComponent<PlayerData>().LessonNum = lesson;
     }
}
