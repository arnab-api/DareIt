using UnityEngine;
using System.Collections;

public class Onner : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        tag = "On";
    }
}
