using UnityEngine;
using System.Collections;

public class FlagOnn2 : MonoBehaviour
{
    public GameObject mag;
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        mag.tag = "Flag";
    }
}

