using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    // easy to Understand ^_^.
    public GameManger gameManger;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        // call the losing video.
        gameManger.GameOver();
    }

}
