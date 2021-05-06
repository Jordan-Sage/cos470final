using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glass : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Text displayText;
    public Text glassText;
    public float volume = 0.5f;
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
        Debug.Log(collider.gameObject.tag == "glass");
        if (collider.gameObject.tag == "glass") {
            Debug.Log(TheLogicAndStuff.GetInstance().glass);
            TheLogicAndStuff.GetInstance().glass += 1;
            Debug.Log(TheLogicAndStuff.GetInstance().glass);
            displayText.text = "Yup, that's glass";
            glassText.text = TheLogicAndStuff.GetInstance().glass + " glass";
        //    audioSource.PlayOneShot(clip, volume);
            
        }
        else if (collider.gameObject.tag == "bin") {
            
        } else {
            displayText.text = "That is a " + collider.gameObject.tag + " ya dummy";
            Debug.Log(collider.gameObject.tag);
        }
    }
}
