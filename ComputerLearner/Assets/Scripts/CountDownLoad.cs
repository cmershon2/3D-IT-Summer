using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CountDownLoad : MonoBehaviour {
    public float Seconds = 5.0f;
    public Text NumberUI;
    public string MenuScene;

    public GameObject PlayerData;

    void Awake()
    {
        if (PlayerData == null)
        {
            Debug.Log("No PlayerData... Attempting to find");
            PlayerData = GameObject.Find("PlayerData");
        }
    }


    // Update is called once per frame
    void Update () {

        Seconds -= Time.deltaTime;
        NumberUI.text = "" + Mathf.Round(Seconds);

        if (Seconds < 0)
        {
            SceneManager.LoadScene(MenuScene);
            DontDestroyOnLoad(PlayerData);
        }
    }
}
