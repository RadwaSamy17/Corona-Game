using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    // to Know if there is whiteCells or not.
    public Text cuteWhiteCell;

    // to Know If We Died or not.
    public Text lifes;

    // to Know if the time is 0 or not
    public Text countdown;

    // to get the tryAgainUI if the player lose.
    public GameObject tryAgainUI;

    // for Fading.
    public Animator transition;

    // to Load the scene that we want.
    public string SceneName;

    void Update()
    {
            
        cuteWhiteCell.text = GameObject.FindGameObjectsWithTag("WhiteCell").Length.ToString();

        if(GameObject.FindGameObjectsWithTag("WhiteCell").Length==0)
        {
            Invoke("Win", 1f);
        }
        else if(lifes.text=="0" || countdown.text=="0")
        {
            Invoke("TryAgainMenu", 1f);
        }
    }
    void TryAgainMenu()
    {
        tryAgainUI.SetActive(true);
    }
    void Win()
    {
        LoadNextLevel(SceneName);
    }
    public void GameOver()
    {
        LoadNextLevel("LosingVideo");
    }
    public void LoadNextLevel(string sceneName)
    {
        StartCoroutine(LoadLevel(sceneName));
    }
    IEnumerator LoadLevel(string sceneName)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(sceneName);
    }
}
