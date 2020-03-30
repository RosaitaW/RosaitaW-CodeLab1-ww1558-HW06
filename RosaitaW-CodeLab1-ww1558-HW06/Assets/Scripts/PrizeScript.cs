using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    public GameObject player;
    public GameObject LockGate;
    public int targetScore;
    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        GameManager.instance.Score++;
        print("score:" +GameManager.instance.Score);
        Destroy(gameObject);
        if (GameManager.instance.Score > targetScore) {
            Destroy(LockGate);
        }
    }
}
