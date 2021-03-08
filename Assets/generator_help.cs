using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class generator_help : MonoBehaviour
{
    level_Generator LG;
 [SerializeField]  float scoreadder;
 
    // Start is called before the first frame update
    void Start()
    {
        LG = FindObjectOfType<level_Generator>().GetComponent<level_Generator>();
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            LG.previous_platform = gameObject;
            LG.Level_Generate();
            LG.ScoreUpdater(scoreadder);
            //StartCoroutine("DestroyThis",1f);
            Destroy(gameObject, 3f);
        }
    }

    //IEnumerator DestroyThis()
    //{
    //    yield return new WaitForSeconds(5f);
    //    Destroy(gameobject);
    //}
}
