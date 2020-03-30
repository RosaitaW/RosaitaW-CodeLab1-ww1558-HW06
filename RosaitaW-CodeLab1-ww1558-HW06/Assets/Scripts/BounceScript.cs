using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerRigid;
    Rigidbody playerCollider;
    public float BounceForce;
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            playerRigid.velocity = transform.up * BounceForce;
            playerRigid.AddForce(Vector3.up * BounceForce);
        }
    }*/


    void OnCollisionEnter(Collision collidedWithThis)
    {
        if (collidedWithThis.transform.name == "Player")
        {
            playerRigid.AddForce(Vector3.up * BounceForce);
            //playerRigid.velocity  = transform.up * BounceForce; //speed is a number variable
        }
    }

}
