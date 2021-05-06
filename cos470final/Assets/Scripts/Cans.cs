using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Debug.Log(collider.gameObject.tag == "can");
        if (collider.gameObject.tag == "can") {
            Debug.Log(TheLogicAndStuff.GetInstance().cans);
            TheLogicAndStuff.GetInstance().cans += 1;
            Debug.Log(TheLogicAndStuff.GetInstance().cans);
            displayText.text = "Yup, that's a can";
            
        } else {
            Debug.Log(collider.gameObject.tag);
        }
    }
}
