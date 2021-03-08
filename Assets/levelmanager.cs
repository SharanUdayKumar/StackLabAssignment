using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{

    bool playclicked = false;
    private void Start()
    {
       
    }
    public void Play()
    {
        if (playclicked == false)
        {
            print("startinggame");
            StartCoroutine("PlayGame");
            playclicked = true;
        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }

   IEnumerator PlayGame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

}
