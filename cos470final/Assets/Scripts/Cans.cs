﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : MonoBehaviour
{
    public int scoreValue = 0;
    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("We in the can method");
        if (collider.gameObject.tag == "can") {
            
            TheLogicAndStuff.GetInstance().cans += 1;

            displayText.text = "Yup, that's a can";
            
        }
    }
}
