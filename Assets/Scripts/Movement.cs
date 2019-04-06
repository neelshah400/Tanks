using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody2D rb;
    protected Joystick joystick;
    public GameObject butL;
    public GameObject butR;
    public GameObject butU;
    public GameObject butD;
    private float moveH;
    private float moveV;
    private float factorH;
    private float factorV;
    public bool left = false;
    public bool right = false;
    public bool down = false;
    public bool up = false;
    public float moveSpeed = 100;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        joystick = FindObjectOfType<Joystick>();
        Input.ResetInputAxes();

    }
	
	// Update is called once per frame
	void Update () {

        factorH = 0;
        factorV = 0;
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)
            || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)
            || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W)
            || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            Input.ResetInputAxes();
        }
        if (Input.GetAxis("Horizontal") <= -1)
        {
            factorH = -1;
        }
        if (Input.GetAxis("Horizontal") >= 1)
        {
            factorH = 1;
        }
        if (Input.GetAxis("Vertical") <= -1)
        {
            factorV = -1;
        }
        if (Input.GetAxis("Vertical") >= 1)
        {
            factorV = 1;
        }
        if (left == true)
        {
            factorH = -1;
        }
        if (right == true)
        {
            factorH = 1;
        }
        if (down == true)
        {
            factorV = -1;
        }
        if (up == true)
        {
            factorV = 1;
        }
        if (joystick.Horizontal > 0 || joystick.Horizontal < 0)
        {
            factorH = joystick.Horizontal;
        }
        if (joystick.Vertical > 0 || joystick.Vertical < 0)
        {
            factorV = joystick.Vertical;
        }
        moveH = factorH * moveSpeed;
        moveV = factorV * moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);

    }

}
