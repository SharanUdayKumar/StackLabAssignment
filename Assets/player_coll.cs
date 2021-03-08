using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_coll : MonoBehaviour
{
    destroy_ball DB;
   level_Generator LG;

    private void Awake()
    {
        LG = FindObjectOfType<level_Generator>().GetComponent<level_Generator>();
        DB = FindObjectOfType<destroy_ball>().GetComponent<destroy_ball>();
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LG.isDead = true;
            DB.Destroy_This();
        }
    }
}
