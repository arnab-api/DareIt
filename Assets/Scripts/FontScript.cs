using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FontScript : MonoBehaviour
{
    public string levelNo;
    public float x1, txt_left, txt_top;

    public Text timerLabel;
    private float time;

    void Start()
    {
        //PlayerPrefs.SetInt("Level" + levelNo + "Score", 0);
        PlayerPrefs.SetInt("Time Needed", 0);
        //Debug.Log(PlayerPrefs.GetInt("PrevTime").ToString());
        time += (float)PlayerPrefs.GetInt("PrevTime");
    }
    void Update()
    {

        time += Time.deltaTime;
        int seconds = (int)(time);

        timerLabel.fontSize = getSize(20);
        timerLabel.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Screen.height * txt_left, Screen.width * txt_top, 0f));
        timerLabel.text = "Level " + levelNo + "           " + seconds.ToString();
        PlayerPrefs.SetInt("Time Needed", (int)time);
    }

    private int getSize(int sz)
    {
        float size = Screen.height / x1;
        int fontSize = Mathf.RoundToInt(size * sz);
        return fontSize;
    }
}
