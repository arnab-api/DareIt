using UnityEngine;
using System.Collections;

public class BackMusic : MonoBehaviour {

	void Start () {
        DontDestroyOnLoad(gameObject);
	}
}
