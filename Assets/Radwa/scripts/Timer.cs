using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public string levelToLoad;
    public string panalToLoad;
    public GameObject q1lUI;
    public GameObject q2lUI;
    public float timer ;
    private Text timerSeconds;


    
    void Start()
    {
        // indecate the timer (string)
        timerSeconds = GetComponent<Text>();
    }

   
    void Update()
    { 
        // decrease the timer every frame
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");

        if (timer <= 0 && panalToLoad == "question1")
        {
            // when time is up in q1

            SceneManager.LoadScene(levelToLoad);
        }

        else if (timer <= 0 && panalToLoad == "question2")
        {
            // when time is up in q2

            SceneManager.LoadScene(levelToLoad);
            q1lUI.SetActive(false);
            q2lUI.SetActive(true);
           
           
        }
        else if (timer <= 0 && panalToLoad == "")
        {
            // when time is up after video
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
