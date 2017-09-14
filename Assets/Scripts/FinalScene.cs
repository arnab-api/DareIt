﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinalScene : MonoBehaviour
{

    public Text txt;
    public float x1, txt_left, txt_top;


    private int getSize(int sz)
    {
        float size = Screen.height / x1;
        int fontSize = Mathf.RoundToInt(size * sz);
        return fontSize;
    }

    void Start()
    {
        txt.fontSize = getSize(20);
        txt.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Screen.height * txt_left, Screen.width * txt_top, 0f));
        txt.text = "Game Over...                      Congratulations!!!              You've Nailed It !!!";
    }
}
