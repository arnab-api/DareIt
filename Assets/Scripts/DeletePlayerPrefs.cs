using UnityEngine;
using System.Collections;

public class DeletePlayerPrefs : MonoBehaviour {

	void Start ()
    {
        PlayerPrefs.DeleteAll();
	}
}
