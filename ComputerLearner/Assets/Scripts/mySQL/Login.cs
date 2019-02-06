using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public InputField UsernameUI;
    public InputField PasswordUI;
    public Text LoginError;
    public bool LoginSuccess = false;
    public GameObject PlayerData;
    public bool LoginVerified = false;
    public GameObject MenuUI;
    public GameObject InsertUI;
    public bool infoFetched = false;
    public bool fetching = false;

    public GameObject LoadingIcon;
    public GameObject LoginBtn;
    public GameObject CreateBtn;

    string LoginURL = "it3d.science/UnityLogin.php";

	
	// Update is called once per frame
	void Update ()
    {
        if(LoginSuccess == true)
        {
            PlayerData.GetComponent<PlayerData>().Username = UsernameUI.text;
            LoginVerified = true;
            if(infoFetched) {
                MenuUI.SetActive(false);
                InsertUI.SetActive(true);
            }
        } if(LoginVerified && !infoFetched && !fetching) {
            StartCoroutine(FetchLessonData(UsernameUI.text));
        }
    }

#region LoginToDataBase
    IEnumerator LoginToDB(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);

        WWW www = new WWW(LoginURL, form);
        while(!www.isDone) {
            continue;
        }
        
        yield return www;
        Debug.Log(www.text);

        if (www.text == "Incorrect password")
        {
            LoginError.text = "Incorrect password";
            StartCoroutine(ErrorFade(1.0f));

            LoginBtn.SetActive(true);
            LoadingIcon.SetActive(false);
        }

        if(www.text == "user not found")
        {
            LoginError.text = "Username not found";
            StartCoroutine(ErrorFade(1.0f));

            LoginBtn.SetActive(true);
            LoadingIcon.SetActive(false);
        }

        if(www.text == "Login Success")
        {
            LoginSuccess = true;
        }

    }
    #endregion

#region FetchLessonData
    IEnumerator FetchLessonData(string username)
    {
        fetching = true;
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        WWW lessonData = new WWW("it3d.science/ULD1.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson1 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson1 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD2.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson2 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson2 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD3.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson3 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson3 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD4.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson4 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson4 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD5.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
         
         while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson5 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson5 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD6.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson6 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson6 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD7.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson7 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson7 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD8.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson8 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson8 = false;
        
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD9.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        while(!lessonData.isDone) {
            continue;
        }
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson9 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson9 = false;
       
        form = new WWWForm();
        form.AddField("username", username);
        lessonData = new WWW("it3d.science/ULD10.php", form);
        
        while(!lessonData.isDone) {
            continue;
        }
        yield return lessonData;
        Debug.Log(lessonData.text);
        
        if(lessonData.text == "1") {
            PlayerData.GetComponent<PlayerData>().Lesson10 = true;
        } else PlayerData.GetComponent<PlayerData>().Lesson10 = false;
        
        infoFetched = true;
        
    }
#endregion

#region UI_Fader
    IEnumerator ErrorFade(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        LoginError.text = "";
    }
    #endregion

#region OnClick
    public void OnClick()
    {
        StartCoroutine(LoginToDB(UsernameUI.text, PasswordUI.text));
        LoginBtn.SetActive(false);
        CreateBtn.SetActive(false);
        LoadingIcon.SetActive(true);
    }
#endregion

}
