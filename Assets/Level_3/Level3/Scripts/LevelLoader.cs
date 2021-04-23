using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // to load the scene that we want.
    public string sceneName;
    
    // for fading
    public Animator transition;

    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
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
