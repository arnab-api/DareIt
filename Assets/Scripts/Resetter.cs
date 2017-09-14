using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Resetter : MonoBehaviour {

    public Collider2D trigg1, down, left;
    public Collider2D res;
	public Rigidbody2D projectile;
	public float resetSpeed = 0.025f;
    public GUISkin theSkin;
    public float backButton_left, backButton_top, backButton_width, backButton_height;
    public float resetButton_left, resetButton_top, resetButton_width, resetButton_height;
    public float levelButton_left, levelButton_top, levelButton_width, levelButton_height;
    public string levelNo;
    public float x1;

    private SpringJoint2D spring;

    void Start ()
	{
        float scale = Screen.height / x1;
        theSkin.button.fontSize = (int)scale;
		spring = projectile.GetComponent <SpringJoint2D>();
	}

    void Update ()
    {
        if(down.tag=="On")
        {
            Reset();
            down.tag = "Untagged";
        }
        if (left.tag == "On")
        {
            StartCoroutine(wait());
            left.tag = "Untagged";
        }
        if (trigg1.tag != "On" && res.tag == "On")
        {
            res.tag = "Untagged";
            StartCoroutine(wait());
        }
	}
	
	void OnTriggerExit2D (Collider2D other) {
		if (other.GetComponent<Rigidbody2D>() == projectile) {
			Reset ();
		}
	}
	
	void Reset () {
        PlayerPrefs.SetInt("PrevTime", PlayerPrefs.GetInt("Time Needed"));
        Application.LoadLevel (Application.loadedLevel);
    }

    public void OnGUI()
    {
        GUI.skin = theSkin;

        if (GUI.Button(new Rect(Screen.width * resetButton_left, Screen.height * resetButton_top, Screen.height * resetButton_width, Screen.width * resetButton_height), "RESET", theSkin.button))
        {
            Reset();
        }

        if (GUI.Button(new Rect(Screen.height* backButton_left, Screen.width* backButton_top, Screen.height * backButton_width, Screen.width * backButton_height), "MENU", theSkin.button))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        Reset();
    }
}
