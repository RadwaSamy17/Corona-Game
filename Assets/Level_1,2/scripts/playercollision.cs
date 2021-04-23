using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playercollision : MonoBehaviour
{
    public int c = 0;
    public Text cellcounter;
    public GameObject completeLevelUI;
    public GameObject tryLevelUI;
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "white")
        {
           
            Destroy(collisionInfo.gameObject);
            c += 1;
            cellcounter.text = c.ToString();
           
        }

        else if (collisionInfo.collider.tag == "Finish" && c>=22)
        {
            completeLevelUI.SetActive(true);
        }
        else if (collisionInfo.collider.tag == "Finish" && c < 22)
        {
            tryLevelUI.SetActive(true);
        }

    }

}
