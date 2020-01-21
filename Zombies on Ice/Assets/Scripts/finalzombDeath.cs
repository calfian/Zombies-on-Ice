using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalzombDeath : MonoBehaviour
{

    public GameObject blood;
    public Transform zombpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "shot")
        {
            Instantiate(blood, zombpos.position, zombpos.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
        if (other.tag == "Player")
        {
            
            Instantiate(blood, zombpos.position, zombpos.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}
