using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("MainMenu");
        //StartCoroutine(wait());
    }
	
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
    }
}
