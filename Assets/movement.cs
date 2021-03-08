using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb2d;
    [SerializeField] float MovementSpeed;

    float mx;
    float my;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(-transform.up * 100);
    }

    // Update is called once per frame
    void Update()
    {

        MovementControls();
        
    }

    private void MovementControls()
    {
        mx = Input.GetAxisRaw("Horizontal");
        //my = Input.GetAxisRaw("Vertical");
        //Vector2 movementy = new Vector2(0, my * MovementSpeed);
        Vector2 movementmotion = new Vector2(mx * MovementSpeed, /*my * MovementSpeed); */rb2d.velocity.y);
        rb2d.velocity = movementmotion;
        //if(Input.GetKeyDown(KeyCode.S))
        //{
        //    print("movingdown");
        //    rb2d.AddForce(movementy);
        //}
        

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    rb2d.AddForce(-transform.right * 5);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb2d.AddForce(transform.right * 5);
        //}
    }

   
}
