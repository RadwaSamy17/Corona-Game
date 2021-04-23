using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenloader : MonoBehaviour
{

    public void SceneLoader()
    {
        SceneManager.LoadScene("bodyinfect"); 
    }
    public void SceneLoader1()
    {
        SceneManager.LoadScene("SampleScene1");
    }
    public void loadlevel3()
    {
        SceneManager.LoadScene("Level3_Wave1");
    }
    public void loadlevel4()
    {
        SceneManager.LoadScene("level1intro");
    }
    public void play()
    {
        SceneManager.LoadScene("areyouready");
    }
    public void loadlevel2()
    {
        SceneManager.LoadScene("level2");
    }
    public void Over()
    {
        SceneManager.LoadScene("StartMenu");
        
    }
  
    
}
