using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonComplete : MonoBehaviour {

    public GameObject PlayerData;
    public bool UpdateLessonData = false;

    string LessonCompURL = "it3d.science/Complete.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space)) CreateUser(inputUserName, inputPassword, inputEmail);
        //PlayerData.GetComponent<PlayerData>().Lesson

        if(PlayerData == null)
        {
            PlayerData = GameObject.Find("PlayerData");
        }
        
        

        //int.TryParse(newLessonNum, out newLessonData);
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 1 && !PlayerData.GetComponent<PlayerData>().Lesson1) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 2 && !PlayerData.GetComponent<PlayerData>().Lesson2) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 3 && !PlayerData.GetComponent<PlayerData>().Lesson3) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 4 && !PlayerData.GetComponent<PlayerData>().Lesson4) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 5 && !PlayerData.GetComponent<PlayerData>().Lesson5) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 6 && !PlayerData.GetComponent<PlayerData>().Lesson6) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 7 && !PlayerData.GetComponent<PlayerData>().Lesson7) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 8 && !PlayerData.GetComponent<PlayerData>().Lesson8) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 9 && !PlayerData.GetComponent<PlayerData>().Lesson9) {
            UpdateLessonData = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 10 && !PlayerData.GetComponent<PlayerData>().Lesson10) {
            UpdateLessonData = true;
        }
    
        
        
	}

    public void SetLessonData(string username, int LessonNum)
    {
    
        Debug.Log("Setting LESSON DATA.");
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("newLesson", LessonNum);

        WWW lessonData = new WWW(LessonCompURL, form);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        Debug.Log(lessonData.text);
    }

    public void OnClick()
    {
    
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 1) {
            PlayerData.GetComponent<PlayerData>().Lesson1 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 2) {
            PlayerData.GetComponent<PlayerData>().Lesson2 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 3) {
            PlayerData.GetComponent<PlayerData>().Lesson3 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 4) {
            PlayerData.GetComponent<PlayerData>().Lesson4 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 5) {
            PlayerData.GetComponent<PlayerData>().Lesson5 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 6) {
            PlayerData.GetComponent<PlayerData>().Lesson6 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 7) {
            PlayerData.GetComponent<PlayerData>().Lesson7 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 8) {
            PlayerData.GetComponent<PlayerData>().Lesson8 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 9) {
            PlayerData.GetComponent<PlayerData>().Lesson9 = true;
        }
        if(PlayerData.GetComponent<PlayerData>().LessonNum == 10) {
            PlayerData.GetComponent<PlayerData>().Lesson10 = true;
        }

        if(UpdateLessonData == true)
        {
            SetLessonData(PlayerData.GetComponent<PlayerData>().Username, PlayerData.GetComponent<PlayerData>().LessonNum);
        }
    }
}
