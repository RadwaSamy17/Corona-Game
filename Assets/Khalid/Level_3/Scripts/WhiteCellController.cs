using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCellController : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;

    public HealthSystem whiteCellHealth;
    public int healthMax = 10;

    public GameObject projectile;
    public float startDelay = 1f;
    public float prodectionIntervals = 4f;
    public GameObject healer;

    int virusDamage;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("InfectedCell").transform;

        whiteCellHealth = GetComponent<HealthSystem>();
        whiteCellHealth = new HealthSystem(healthMax);

        InvokeRepeating("WhiteShootsProduction", startDelay, prodectionIntervals);

        virusDamage = new VirusController_L3().damage;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Virus"))
        {
            whiteCellHealth.Damage(virusDamage);
        }
    }
    void WhiteShootsProduction()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
    void Destroy()
    {
        if (whiteCellHealth.GetHealth() == 0)
        {
            // Debug.Log("Kill WhiteCell");
            Instantiate(healer, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
