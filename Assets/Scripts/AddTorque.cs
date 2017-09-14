using UnityEngine;
using System.Collections;

public class AddTorque : MonoBehaviour {
    public float torque;
	void Start () {
        GetComponent<Rigidbody2D>().AddTorque(torque);
	}
}
