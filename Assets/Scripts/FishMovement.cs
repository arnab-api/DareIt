using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour
{

    public float sx, sy;

    bool flag = false;
    void Update()
    {
        float x = sx * (Time.deltaTime);
        float y = sy * (Time.deltaTime);


        if (transform.position.x < -12f)
        {
            Vector3 pos;
            pos.x = 13;
            pos.y = transform.position.y;
            pos.z = transform.position.z;
            transform.position = pos;
        }
        //if (transform.position.x > 4f) flag = false;
        //if (flag) transform.Translate(-x, -y, 0);
         transform.Translate(x, y, 0);
    }
}
