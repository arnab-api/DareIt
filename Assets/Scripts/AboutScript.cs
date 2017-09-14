using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour {

    public int flag;
    public float x1, x2, y1, y2, fs, backButton_left, backButton_top, backButton_width, backButton_height;
    public GUISkin theSkin;
    public Vector2 scrollPosition = Vector2.zero;
    string aboutString, insString;

    void Start()
    {
        float scale = Screen.height / fs;
        theSkin.textArea.fontSize = (int)scale;
    }

    void OnGUI()
    {
        aboutString="\n   This game was built by two SUST CSE'13 students Maruf Ahmed Mridul and Arnab Sen Sharma. It was built as a project for CSE-200 under the supervision of Mr. Sheikh Nabil Mohammad, Lecturer, CSE, SUST and Mr. Biswapriyo Chakrabarty, Lecturer, CSE, SUST.\n   The game was built for educaional purposes only and it shall not be used for any kind of commercial purposes.\n   All images, sounds, used in this game were collected via google search. We don't hold any copyright on them. If they match with any of the existing games it is unintentional.\n";
        insString = "\n The objective of the game is very simple. The player has to pass the ball through the ring. The Player may face some difficulties in higher levels. But, some clues can make his/her life easier. Here are the clues -\n    There are three types of balls - 1. The White one is a simple ball, 2. The Red one is super bouncy ball and 3. The Dark Purple one is heavier than others.\n    The springboard is to be dragged down and released when necessary\n    Different kinds of obstacles may make the game a bit harder, but they can also be helpful... ;)\n The game may seem a bit harder...but that's what we dare you. Are you up for the task ?? :)\n";
        GUI.skin = theSkin;
        
        GUILayout.BeginArea(new Rect(Screen.width * x1, Screen.height * y1, Screen.width * x2, Screen.height * y2));
       // scrollPosition = GUI.BeginScrollView(new Rect(Screen.width*x1, Screen.height*y1, Screen.width*x2, Screen.height*y2), scrollPosition, new Rect(0, 0, 0.65f*Screen.width, 2200));
        //GUI.TextArea
        //GUI.EndScrollView();
        
        if(flag==1) GUILayout.TextArea(aboutString, GUILayout.Width(Screen.width*x2));
        else if (flag == 0) GUILayout.TextArea(insString, GUILayout.Width(Screen.width * x2));
        // GUILayout.EndScrollView();
        GUILayout.EndArea();
        if (GUI.Button(new Rect(Screen.height * backButton_left, Screen.height * backButton_top, Screen.height * backButton_width, Screen.width * backButton_height), "MENU", theSkin.button))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
