﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MovableObjectScript : MonoBehaviour
{
    float mouseZPos; 
    Rigidbody rb; 
    Collider col; 
    string filePath; 

    void Start()
    {
        filePath = Application.dataPath + "/" + name + ".json";

        rb = GetComponent<Rigidbody>(); 
        col = GetComponent<Collider>(); 

        if (File.Exists(filePath)) //if the save file exists
        {
            string jsonStr = File.ReadAllText(filePath); //load it as a string

            Vector3 savePos = JsonUtility.FromJson<Vector3>(jsonStr); //turn the Json into an object

            rb.MovePosition(savePos); //move the savePos
        }
    }

    void OnMouseDrag()
    { //if you drag the mouse over the gameObject
        mouseZPos = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; //get the Z position of the object at the screen

        rb.isKinematic = true; //make it uneffected by physics
        rb.MovePosition(GetMouseAsWorldPoint()); //move it to the new mouse position

        col.enabled = false; //turn off the collider
    }

    private void OnMouseUp() //if you release the mouse over the object
    {
        col.enabled = true; //trun on collisions
    }

    Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition; 

        mousePoint.z = mouseZPos; 

        return Camera.main.ScreenToWorldPoint(mousePoint); 
    }

    private void OnApplicationQuit()
    {
        string pos = JsonUtility.ToJson(transform.position, true);
        File.WriteAllText(filePath, pos);
    }
}
