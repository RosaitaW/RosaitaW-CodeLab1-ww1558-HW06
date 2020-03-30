using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    Rigidbody playerCollider;
    public float force;
    public KeyCode left;
    public KeyCode right;
    
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))//if D is pressed
        {
            playerCollider.AddForce(Vector3.right * force);//apply a force using the "force" var
        }
        else if (Input.GetKey(left))
        {
            playerCollider.AddForce(Vector3.left * force);
        }
    }
}
