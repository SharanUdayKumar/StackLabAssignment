using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedincrease : MonoBehaviour
{
    matchspeed MS;
    // Start is called before the first frame update
    static int coll_counter;
   public bool hastriggered = false;
    private void Awake()
    {
        MS = FindObjectOfType<matchspeed>().GetComponent<matchspeed>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && hastriggered == false)
        {
            coll_counter++;
            MS.IncreaseSpeed(coll_counter);
            hastriggered = true;
        }
    }
}
