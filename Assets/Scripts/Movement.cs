using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody2D rb;
    public GameObject butL;
    public GameObject butR;
    public GameObject butU;
    public GameObject butD;
    private float moveH;
    private float moveV;
    private float factorH;
    private float factorV;
    public float moveSpeed = 100;
    public bool left = false;
    public bool right = false;
    public bool up = false;
    public bool down = false;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        Input.ResetInputAxes();

    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.A))
        {
            Input.ResetInputAxes();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.D))
        {
            Input.ResetInputAxes();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && Input.GetKeyUp(KeyCode.W))
        {
            Input.ResetInputAxes();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && Input.GetKeyUp(KeyCode.S))
        {
            Input.ResetInputAxes();
        }
        factorH = 0;
        factorV = 0;
        if (Input.GetAxis("Horizontal") == -1)
        {
            factorH = -1;
        }
        if (Input.GetAxis("Horizontal") == 1)
        {
            factorH = 1;
        }
        if (Input.GetAxis("Vertical") == -1)
        {
            factorV = -1;
        }
        if (Input.GetAxis("Vertical") == 1)
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
        moveH = factorH * moveSpeed;
        moveV = factorV * moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);

    }

    public void setLeftTrue() { left = true; }
    public void setLeftFalse() { left = false; }
    public void setRightTrue() { right = true; }
    public void setRightFalse() { right = false; }
    /*public void setUpTrue() { left = true; }
    public void setLeftFalse() { left = false; }
    public void setRightTrue() { right = true; }
    public void setRightFalse() { right = false; }*/
    //a

}
