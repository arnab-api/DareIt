using UnityEngine;
using System.Collections;

public class BarMovement : MonoBehaviour
{

    public float sx, sy;

    bool flag = false;
    void Update()
    {
        float x = sx * (Time.deltaTime);
        float y = sy * (Time.deltaTime);

        if (transform.position.x < -3f) flag = true;
        if (transform.position.x > 4f) flag = false;
        if (flag) transform.Translate(-x, -y, 0);
        else transform.Translate(x, y, 0);
    }
}
