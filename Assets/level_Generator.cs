using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class level_Generator : MonoBehaviour
{
    [SerializeField] public GameObject previous_platform;
    [SerializeField] public Transform final_platform;
    [SerializeField] GameObject platformprefab;
    [SerializeField] TextMeshProUGUI currentscoretext;
    [SerializeField] TextMeshProUGUI highscoretext;
    [SerializeField] float totalscore;
    public bool isDead;
    float highscore;

    private void Start()
    {
        highscoretext.text = "High Score :-" + PlayerPrefs.GetFloat("HighScore",0);
        print(Screen.height);
        print(Screen.width);
    }

    private void Update()
    {
        HighScoreUpdater();
    }

    private void HighScoreUpdater()
    {
        if (isDead)
        {
            highscore = totalscore;
            print("is dead so highscore is" + highscore);
            //highscoretext.text = "High Score :-" + highscore;
        }
        if (highscore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", highscore);
        }
        if(isDead)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ScoreUpdater(float score)
    {
      totalscore = totalscore + score;
        print(score);
        currentscoretext.text = "Current Score :- " + totalscore;
        
    }
    public void Level_Generate()
    {
        var xpos = final_platform.position.x + Random.Range(-6f, 6f);
        if(xpos > 8f )
        {
            xpos = 8f;
        }
        if(xpos < -8f)
        {
            xpos = -8f;
        }
        Vector2 newpos = new Vector2(xpos, final_platform.position.y - 4f);
        GameObject ptf = Instantiate(platformprefab, newpos, Quaternion.identity);
        ptf.transform.localScale = new Vector2(Random.Range(.8f, 1.5f), 1f);
        final_platform = ptf.transform;
    }

}
