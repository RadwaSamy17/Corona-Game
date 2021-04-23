using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealerController : MonoBehaviour
{
    public int healAmount = 1;

    private void Update()
    {
        // Rotate an object when Instantiated from whiteCell.

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);                                                                                     
    }

    // If Object Get into The Healer. 
    private void OnTriggerEnter(Collider other)
    {
        // If that Object is the Infected Cell.

        if(other.CompareTag("InfectedCell"))
        {
            Destroy(gameObject);

            // Call the Heal Method from InfectedCell Script and increase the Health by healAmount.

            GameObject.FindGameObjectWithTag("InfectedCell").GetComponent<PlayerController_L3>().playerHealth.Heal(healAmount);
        }
    }
}
