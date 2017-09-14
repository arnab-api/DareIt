using UnityEngine;
using System.Collections;

public class FlagOn : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        tag = "Flag";
    }
}
