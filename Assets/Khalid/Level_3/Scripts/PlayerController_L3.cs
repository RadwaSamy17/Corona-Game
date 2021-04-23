using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController_L3 : MonoBehaviour
{
    // here is the player moving, rotate with mouse position, shoot virus and his health.


    // for Lifes Text On the Screen.
    public Text lifes;

    // make an object from The HealthSystem Class
    public HealthSystem playerHealth;

    // Define Our MaxHealth for Our InfectedCell.
    public int healthMax = 5;

    // From its Names ^_^
    int whiteShotsDamage;
    public int whiteCellHitDamage = 5;

    // for Movement Speed.
    public float speed = 15f;

    // to get Movement Inputs.
    Vector3 moveInput;
    Vector3 moveVelocity;
    Rigidbody myRigidbody;

    public GameObject projectile;

    // This Variables for Making a Delay Between Shoots.
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    
    AudioSource mAudioSrc;


    void Start()
    {
        
        // Get Rigidbody Component of our Object
        myRigidbody = GetComponent<Rigidbody>();

        playerHealth = GetComponent<HealthSystem>();
        playerHealth = new HealthSystem(healthMax);

        whiteShotsDamage = new WhiteShotsController().damage;

        // Get Audio Source Component
        mAudioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {
        // Change The Life Text to be equal to the InfectedCell Health
        lifes.text = playerHealth.GetHealth().ToString();

        // Call The Destroy Method That Check if The InfectCell'Health is equal to 0 then destroy it.
        Destroy();                                                                        
        
        // Get The Input in Vector3
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")); 
        moveVelocity = moveInput * speed;

        // if the player click the left mouse button he will shoot.

        if (Input.GetButtonDown("Fire1") && Time.time>nextFire)                                             
        {
            // play Shooting Audio
            mAudioSrc.Play();

            Shoot();
            // To Make A Delay Between Shoots.
            nextFire = Time.time + fireRate;                                                                
        }
    }
    void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;

        // rotate with mouse.//

        // Generate a plane that intersects the transform's position with an upwards normal.
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        // Generate a ray from the cursor position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Determine the point where the cursor ray intersects the plane.
        float hitdist = 0.0f;
        // If the ray is parallel to the plane, Raycast will return false.
        if (playerPlane.Raycast(ray, out hitdist))
        {
            // Get the point along the ray that hits the calculated distance.
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Debug.DrawLine(ray.origin, targetPoint, Color.black);

            transform.LookAt(targetPoint);
            
        }
        
    }
    
    // When an Object Thouch Our InfectedCell.
    private void OnCollisionEnter(Collision collision)
    {
        // If That Object is the WhiteCell Shots Then the health of InfectedCell will decrease by whiteShotsDamage amount.
        // We didn't Destroy WhiteCell Shots here because it will be Destroied in its Script When it Touch Something.
        if (collision.collider.CompareTag("WhilteCell_Shots"))
        {
            playerHealth.Damage(whiteShotsDamage);
        }

        // If That Object is the WhiteCell Then the health of InfectedCell will decrease by whiteCellHitDamage amount and Destroy the WhiteCell.
        if(collision.collider.CompareTag("WhiteCell"))
        {
            playerHealth.Damage(whiteCellHitDamage);
            Destroy(collision.gameObject);
        }
    }

    // We use This Method to Instantiate our Virus when Click left Mouse Button.
    void Shoot()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }

    // check if Player Health is 0 or Not
    void Destroy()
    {
        if(playerHealth.GetHealth()==0)
        {
            Destroy(gameObject);
        }
    }
}
