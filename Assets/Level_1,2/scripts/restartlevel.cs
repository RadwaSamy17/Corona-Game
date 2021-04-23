using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartlevel : MonoBehaviour
{
    [SerializeField]
     
    // restart the level if any red blood cells collide with the player 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
