using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tryagain0 : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject tryLevelUI;
    public void level2loader()
    {
          
        completeLevelUI.SetActive(false);
    }
    public void level2loader2()
    {
        SceneManager.LoadScene("level2");
        tryLevelUI.SetActive(false);
    }
}
