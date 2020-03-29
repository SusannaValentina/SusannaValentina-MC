using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 400f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Force);
            transform.localEulerAngles = new Vector3(0, 0, 15);
        } 
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
