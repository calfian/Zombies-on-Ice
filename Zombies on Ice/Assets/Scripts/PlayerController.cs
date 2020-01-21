using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
  float rotationSpeed = 200.0f;
    public float thrustForce = 3f;

    public float fireRate;
    private float nextFire;

    public GameObject shot;
    public Transform shotSpawn;

    private Rigidbody2D rb;

    public GameObject blood;

    private Transform self;
    
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        self = GetComponent<Transform>();
    }
 
    void FixedUpdate () 
    {
      transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*rotationSpeed * Time.deltaTime);
 
      rb.AddForce(transform.up * thrustForce *Input.GetAxis("Vertical"));

     
    }

  void  Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
           
        }

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "zombShot")
        {
            Instantiate(blood, self.position, self.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }


}
