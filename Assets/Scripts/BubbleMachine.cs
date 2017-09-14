using UnityEngine;
using System.Collections;

public class BubbleMachine : MonoBehaviour {

    public Rigidbody2D b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12;
    Vector3 pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12;

	// Use this for initialization
	void Start () {
         pos1 = b1.position;
         pos2 = b2.position;
         pos3 = b3.position;
         pos4 = b4.position;
         pos5 = b5.position;
         pos6 = b6.position;
         pos7 = b7.position;
         pos8 = b8.position;
         pos9 = b9.position;
         pos10 = b10.position;
         pos11 = b11.position;
         pos12 = b12.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (b1.position.y > 6)
        {
            Vector3 pos;
            pos.x = b1.position.x;
            pos.y = pos1.y;
            pos.z = b1.position.y;
            b1.position = pos;
            b1.velocity = new Vector3(0, 0, 0);

        }
        if (b2.position.y > 6)
        {
            Vector3 pos;
            pos.x = b2.position.x;
            pos.y = pos2.y;
            pos.z = b2.position.y;
            b2.position = pos;
            b2.velocity = new Vector3(0, 0, 0);
        }
        if (b3.position.y > 6)
        {
            Vector3 pos;
            pos.x = b3.position.x;
            pos.y = pos3.y;
            pos.z = b3.position.y;
            b3.position = pos;
            b3.velocity = new Vector3(0, 0, 0);
        }
        if (b4.position.y > 6)
        {
            Vector3 pos;
            pos.x = b4.position.x;
            pos.y = pos4.y;
            pos.z = b4.position.y;
            b4.position = pos;
            b4.velocity = new Vector3(0, 0, 0);
        }
        if (b5.position.y > 6)
        {
            Vector3 pos;
            pos.x = b5.position.x;
            pos.y = pos5.y;
            pos.z = b5.position.y;
            b5.position = pos;
            b5.velocity = new Vector3(0, 0, 0);
        }
        if (b6.position.y > 6)
        {
            Vector3 pos;
            pos.x = b6.position.x;
            pos.y = pos6.y;
            pos.z = b6.position.y;
            b6.position = pos;
            b6.velocity = new Vector3(0, 0, 0);
        }
        if (b7.position.y > 6)
        {
            Vector3 pos;
            pos.x = b7.position.x;
            pos.y = pos7.y;
            pos.z = b7.position.y;
            b7.position = pos;
            b7.velocity = new Vector3(0, 0, 0);
        }
        if (b8.position.y > 6)
        {
            Vector3 pos;
            pos.x = b8.position.x;
            pos.y = pos8.y;
            pos.z = b8.position.y;
            b8.position = pos;
            b8.velocity = new Vector3(0, 0, 0);
        }
        if (b9.position.y > 6)
        {
            Vector3 pos;
            pos.x = b9.position.x;
            pos.y = pos9.y;
            pos.z = b9.position.y;
            b9.position = pos;
            b9.velocity = new Vector3(0, 0, 0);
        }
        if (b10.position.y > 6)
        {
            Vector3 pos;
            pos.x = b10.position.x;
            pos.y = pos10.y;
            pos.z = b10.position.y;
            b10.position = pos;
            b10.velocity = new Vector3(0, 0, 0);
        }
        if (b11.position.y > 6)
        {
            Vector3 pos;
            pos.x = b11.position.x;
            pos.y = pos11.y;
            pos.z = b11.position.y;
            b11.position = pos;
            b11.velocity = new Vector3(0, 0, 0);
        }
        if (b12.position.y > 6)
        {
            Vector3 pos;
            pos.x = b12.position.x;
            pos.y = pos12.y;
            pos.z = b12.position.y;
            b12.position = pos;
            b12.velocity = new Vector3(0, 0, 0);
        }
    }
}
