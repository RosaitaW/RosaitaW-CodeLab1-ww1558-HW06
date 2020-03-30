using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;
    //Property for score
    //A property wraps a variable and allows you to call a function
    //whenever the value of the variable is used or set
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value; //set "score" to whatever value was passed
        }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        { //instance hasn't been set yet
            instance = this; //set instance to this object
            DontDestroyOnLoad(gameObject); //Dont Destroy this object when you load a new scene
        }
        else
        { //if the instance is already set to an object
            Destroy(gameObject); //destroy this new object, so there is only ever one
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
