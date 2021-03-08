using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchspeed : MonoBehaviour
{
    [SerializeField] movement mmt;
    [SerializeField] Rigidbody2D rb2d;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mmt = FindObjectOfType<movement>();
       
       rb2d.AddForce(-transform.up * 150);
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    //Vector2 cameraspeed = new Vector2(0, mmt.rb2d.velocity.y);
    //    //rb2d.velocity = cameraspeed;
    //}
    public void IncreaseSpeed(int collision_counter)
    {
        if (collision_counter <= 10)
        {
            Debug.Log("increasing speed");
            rb2d.AddForce(-transform.up * 15f);
        }
        else if (collision_counter > 10)
        {
            return;
        }
    }
}
