using UnityEngine;
using System.Collections;

public class SprDragg : MonoBehaviour
{
    public Transform magnet;
    private bool drag;
    private Rigidbody2D myRigidbody;
    private bool wasKinematic;
    public float x_fix = 0f;
    Touch tou;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        wasKinematic = myRigidbody.isKinematic;
    }

    bool checkTouch(Vector3 touchPos)
    {
        bool flag = false;
        float tx = touchPos.x;
        float ty = touchPos.y;
        float sx = transform.position.x;
        float sy = transform.position.y;
        float dis = (tx - sx) * (tx - sx) + (ty - sy) * (ty - sy);
        float rad = 2.4f;
        rad *= rad;
        if (dis <= rad) flag = true;

        return flag;
    }


    void Update()
    {

        foreach (Touch touch in Input.touches)
        {
            tou = touch;
            Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(tou.position);
            if (checkTouch(mouseWorldPoint) == true)
            {
                if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                //if (touch.phase == TouchPhase.Moved)
                {
                    DragFunction();
                    drag = true;
                    myRigidbody.isKinematic = true;
                }
                else
                {
                    if (drag == true)
                        myRigidbody.isKinematic = false;
                    drag = false;
                }
            }
        }
    }

    void DragFunction()
    {
        // We are converting a 2D mouse coordinate to 3D
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(tou.position.x, tou.position.y, distance_to_screen));
        // Update GameObject position
        if (checkTouch(pos_move) == true)
        {
            if (pos_move.y > magnet.position.y) pos_move.y = magnet.position.y;
            if (pos_move.y > -2) pos_move.y = -2;
            if (pos_move.y < -4.5f) pos_move.y = -4.5f;
            transform.position = new Vector3(x_fix, pos_move.y, pos_move.z);
        }
    }

}
