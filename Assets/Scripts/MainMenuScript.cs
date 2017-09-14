using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public float x1, y1, y2, y3, y4, y5;
    public Canvas confirmation;
    public Button yes;
    public Button no;
    public GUISkin theSkin;
    public Texture2D ques, quit;


    public TextAsset imageAsset;

    GUIContent con1 = new GUIContent();
    GUIContent con2 = new GUIContent();

    void Start (){

        /*Texture2D tex = new Texture2D(5, 5);
        tex.LoadImage(imageAsset.bytes);
        GetComponent<Renderer>().material.mainTexture = tex;*/

        con1.image = (Texture2D)ques;
        con2.image = (Texture2D)quit;
        float scale = Screen.height / x1;
        theSkin.button.fontSize = (int)scale;
        confirmation = confirmation.GetComponent<Canvas>();
        yes = yes.GetComponent<Button>();
        no = no.GetComponent<Button>();
        confirmation.enabled = false;
        yes.enabled = false;
        no.enabled = false;
    }

    void OnGUI(){
        GUI.skin = theSkin;

        if(GUI.Button(new Rect(Screen.width*.32f,Screen.height*y1,Screen.width*.40f,Screen.height*.13f),"Let's Play", theSkin.button))
        {
            if (!confirmation.enabled)
            {
                PlayerPrefs.SetInt("PrevTime", 0);
                SceneManager.LoadScene("Level1");
            }
        }

        if (GUI.Button(new Rect(Screen.width * .32f, Screen.height * y2, Screen.width * .40f, Screen.height * .13f), "Levels", theSkin.button))
        {
            if (!confirmation.enabled)
            {
                SceneManager.LoadScene("LevelSelect");
            }
        }

        if (GUI.Button(new Rect(Screen.width * .8f, Screen.height * y4, Screen.width * .10f, Screen.height * .15f), con1))
        {
            if (!confirmation.enabled)
            {
                SceneManager.LoadScene("About");
            }
        }

        if (GUI.Button(new Rect(Screen.width * .32f, Screen.height * y5, Screen.width * .40f, Screen.height * .13f), "Instructions", theSkin.button))
        {
            if (!confirmation.enabled)
            {
                SceneManager.LoadScene("Instructions");
            }
        }

        if (GUI.Button(new Rect(Screen.width * .8f, Screen.height * y3, Screen.width * .10f, Screen.height * .15f), con2))
        {
            if (!confirmation.enabled)
            {
                QuitPress();
            }
        }
    }

    public void QuitPress()
    {
        confirmation.enabled = true;
        yes.enabled = true;
        no.enabled = true;
    }

    public void NoPress()
    {
        confirmation.enabled = false;
        yes.enabled = false;
        no.enabled = false;
    }

    public void YesPress()
    {
        Application.Quit();
    }
}
