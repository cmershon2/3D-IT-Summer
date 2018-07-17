using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : MonoBehaviour {
    public GameObject playerData;
    public int LessonComp;
    public string username;
    
    public Color CompleteColor;
    public Color AssignedColor;

    public Button[] btn;

    public Button L1;
    public Button L2;
    public Button L3;
    public Button L4;
    public Button L5;
    public Button L6;
    public Button L7;
    public Button L8;
    public Button L9;
    public Button L10;


    // Use this for initialization
    void Awake () {
        if (playerData == null)
        {
            playerData = GameObject.Find("PlayerData");
        }
    }
	
	// Update is called once per frame
	void Update () {
        bool Lesson1 = playerData.GetComponent<PlayerData>().Lesson1;
        bool Lesson2 = playerData.GetComponent<PlayerData>().Lesson2;
        bool Lesson3 = playerData.GetComponent<PlayerData>().Lesson3;
        bool Lesson4 = playerData.GetComponent<PlayerData>().Lesson4;
        bool Lesson5 = playerData.GetComponent<PlayerData>().Lesson5;
        bool Lesson6 = playerData.GetComponent<PlayerData>().Lesson6;
        bool Lesson7 = playerData.GetComponent<PlayerData>().Lesson7;
        bool Lesson8 = playerData.GetComponent<PlayerData>().Lesson8;
        bool Lesson9 = playerData.GetComponent<PlayerData>().Lesson9;
        bool Lesson10 = playerData.GetComponent<PlayerData>().Lesson10;

#region ColorIfs
        if (Lesson1)
        {
            L1.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L1.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson2)
        {
            L2.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L2.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson3)
        {
            L3.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L3.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson4)
        {
            L4.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L4.GetComponent<Image>().color = AssignedColor;
            
        }

        if (Lesson5)
        {
            L5.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L5.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson6)
        {
            L6.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L6.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson7)
        {
            L7.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L7.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson8)
        {
            L8.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L8.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson9)
        {
            L9.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L9.GetComponent<Image>().color = AssignedColor;
        }

        if (Lesson10)
        {
            L10.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L10.GetComponent<Image>().color = AssignedColor;
        }
#endregion


    }

    public void LogoutClick()
    {
        
        username = playerData.GetComponent<PlayerData>().Username;
        
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        WWW lessonData = new WWW("it3d.science/UnityLogout.php", form);
        
        Destroy(playerData);
        
        
    }
}
