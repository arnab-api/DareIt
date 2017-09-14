using UnityEngine;
using System.Collections;

public class MusicGenerator : MonoBehaviour {
    public GameObject music;

	void Start () {
        GameObject G = GameObject.FindGameObjectWithTag("GameController");
        if(!G)
        {
            Instantiate(music, Vector3.zero, Quaternion.identity);
        }
	}
}
