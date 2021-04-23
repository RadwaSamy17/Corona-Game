using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteShotsController : MonoBehaviour
{
    public float speed = 10f;
    Transform target;
    Vector3 targetPos;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("InfectedCell").transform;
        targetPos = target.position;
        transform.LookAt(targetPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("InfectedCell"))
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("InfectedCell").GetComponent<PlayerController_L3>().playerHealth.Damage(damage);
        }
        else if (other.CompareTag("Edges") || other.CompareTag("RedBloodCell"))
        {
            Destroy(gameObject);
        }
    }
}
