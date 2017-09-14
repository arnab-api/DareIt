using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelCompleted : MonoBehaviour {

    public GUISkin theSkin;
    public string levelNo, levelNoPrev;
    public float x1, proceedButton_left, proceedButton_top, proceedButton_width, proceedButton_height;
    public float playButton_left, playButton_top, playButton_width, playButton_height;
    public float backButton_left, backButton_top, backButton_width, backButton_height;

    void Start () {
        float scale = Screen.height / x1;
        theSkin.button.fontSize = (int)scale;
    }

    public void OnGUI()
    {
        GUI.skin = theSkin;

        if (levelNo != "20")
        {
            if (GUI.Button(new Rect(Screen.width * proceedButton_left, Screen.height * proceedButton_top, Screen.height * proceedButton_width, Screen.width * proceedButton_height), "Proceed to Level " + levelNo, theSkin.button))
            {
                SceneManager.LoadScene("Level" + levelNo);
            }

            if (GUI.Button(new Rect(Screen.width * playButton_left, Screen.height * playButton_top, Screen.height * playButton_width, Screen.width * playButton_height), "Play Again", theSkin.button))
            {
                SceneManager.LoadScene("Level" + levelNoPrev);
            }
        }

        if (GUI.Button(new Rect(Screen.height * backButton_left, Screen.width * backButton_top, Screen.height * backButton_width, Screen.width * backButton_height), "MENU", theSkin.button))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
