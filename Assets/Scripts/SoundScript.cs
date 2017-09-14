using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {
    public AudioSource aud;
    void OnCollisionEnter2D()
    {
        aud.Play();
    }
}
