using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cans : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Text displayText;
    public float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
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
         
        //    audioSource.PlayOneShot(clip, volume);
            
        }
        if (collider.gameObject.tag == "bin") {
            
        } else {
            displayText.text = "That looks like a " + collider.gameObject.tag + " ya dummy";
            Debug.Log(collider.gameObject.tag);
        }
    }
}
