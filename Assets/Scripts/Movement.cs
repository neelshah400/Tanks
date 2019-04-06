using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody2D rb;
    public GameObject butL;
    public GameObject butR;
    private float moveDir;
    private float factor;
    public float moveSpeed = 100;
    public bool left = false;
    public bool right = false;

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
        factor = 0;
        if (Input.GetAxis("Horizontal") == -1)
        {
            factor = -1;
        }
        if (Input.GetAxis("Horizontal") == 1)
        {
            factor = 1;
        }
        if (left == true)
        {
            factor = -1;
        }
        if (right == true)
        {
            factor = 1;
        }
        moveDir = factor * moveSpeed;
        rb.velocity = new Vector2(moveDir, rb.velocity.y);

    }

    public void setLeftTrue() { left = true; }
    public void setLeftFalse() { left = false; }
    public void setRightTrue() { right = true; }
    public void setRightFalse() { right = false; }

}
