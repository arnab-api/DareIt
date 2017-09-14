using UnityEngine;
using System.Collections;

public class SpringDragging : MonoBehaviour
{

    private bool drag;
    private Rigidbody2D myRigidbody;
    private bool wasKinematic;
    public float x_fix = 0f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        wasKinematic = myRigidbody.isKinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (drag == true)
        {
            DragFunction();
        }
    }

    // Checks if the mouse button is pressed
    void OnMouseDown()
    {
        drag = true;
        myRigidbody.isKinematic = true;
    }

    // Checks if the mouse button is released
    void OnMouseUp()
    {

        // Update flags
        if (drag == true)
            myRigidbody.isKinematic = wasKinematic;
        drag = false;
    }

    void DragFunction()
    {
        // We are converting a 2D mouse coordinate to 3D
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        // Update GameObject position
        if (pos_move.y > -2) pos_move.y = -2;
        if (pos_move.y < -4.5f) pos_move.y = -4.5f;
        transform.position = new Vector3(x_fix, pos_move.y, pos_move.z);
    }

}
