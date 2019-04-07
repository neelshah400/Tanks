using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody2D rb;
    public float moveSpeed = 0;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        //joystick = FindObjectOfType<Joystick>();
        Input.ResetInputAxes();

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mouseOnScreen = (Vector2)Camera.main.WorldToViewportPoint(Input.mousePosition);
        float angle = 90 + Mathf.Atan2(positionOnScreen.y - mouseOnScreen.y, positionOnScreen.x - mouseOnScreen.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        if (Input.GetAxis("Vertical") >= 1)
        {
            moveSpeed = 200;
        }
        else
        {
            moveSpeed = 0;
        }
        rb.AddRelativeForce(new Vector2(0, moveSpeed));

    }

    public Vector2 sendPosition()
    {
        return Camera.main.WorldToViewportPoint(transform.position);
    }
}
