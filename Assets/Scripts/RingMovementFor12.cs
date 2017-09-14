using UnityEngine;
using System.Collections;

public class RingMovementFor12 : MonoBehaviour
{

    public float sx, sy;

    bool flag = false;
    void Update()
    {
        float x = sx * (Time.deltaTime);
        float y = sy * (Time.deltaTime);

        if (transform.position.x < 0) flag = true;
        if (transform.position.x > 7.5f) flag = false;
        if (flag) transform.Translate(-x, -y, 0);
        else transform.Translate(x, y, 0);
    }
}
