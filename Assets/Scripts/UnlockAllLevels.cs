using UnityEngine;
using System.Collections;

public class UnlockAllLevels : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 1; i < 20; i++)
        {
            PlayerPrefs.SetInt("Level"+ i.ToString() +"Passed", 10);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
