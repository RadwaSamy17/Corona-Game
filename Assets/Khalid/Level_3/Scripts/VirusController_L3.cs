using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController_L3 : MonoBehaviour
{
    public float speed = 7f;
    public int damage = 2;
    
    // Update is called once per frame
    void Update()
    {
        // to Make Our Virus Move Forward when it Instantiated from ShootingPoint on InfectedCell.

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // When Object Thouch the Virus or our Virus Touch an Object.
    private void OnCollisionEnter(Collision collision)
    {
        // if That Object isn't the InfectCell then destroy our Virus.

        if(!(collision.collider.CompareTag("InfectedCell")))
            Destroy(gameObject);
    }
}
