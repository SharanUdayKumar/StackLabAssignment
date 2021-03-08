using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highscoremanager : MonoBehaviour
{
    float highscore;
    [SerializeField] TextMeshProUGUI TMP;
    // Start is called before the first frame update
    void Start()
    {
        TMP.text = "High Score :- " + PlayerPrefs.GetFloat("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
