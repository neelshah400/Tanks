using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Rigidbody2D rb;
    Movement mv;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        rb.gameObject.SetActive(false);
        mv = GameObject.FindObjectOfType(typeof(Movement)) as Movement;
        Input.ResetInputAxes();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 start = new Vector2();
        Debug.Log("does this even pop up plz god");
        start = mv.sendPosition();
        transform.position = start;
        Vector2 mouseOnScreen = (Vector2)Camera.main.WorldToViewportPoint(Input.mousePosition);
        float angle = 90 + Mathf.Atan2(start.y - mouseOnScreen.y, start.x - mouseOnScreen.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        if (Input.GetKeyUp(KeyCode.Mouse1)){
            rb.gameObject.SetActive(true);
            GameObject shot = Instantiate(rb.gameObject, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
        }

    }
}
