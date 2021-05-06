using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottles : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Text displayText;
    public Text bottleText;
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
        Debug.Log("We in the bottle method");
        Debug.Log(collider.gameObject.tag == "bottle");
        if (collider.gameObject.tag == "bottle") {
            TheLogicAndStuff.GetInstance().bottles += 1;
            Debug.Log(TheLogicAndStuff.GetInstance().bottles);
            displayText.text = "Yup, that's a bottle";
            bottleText.text = TheLogicAndStuff.GetInstance().bottles + " bottles";
        //    audioSource.PlayOneShot(clip, volume);
            
        }
        else if (collider.gameObject.tag == "bin") {
            
        } else {
            displayText.text = "That is a " + collider.gameObject.tag + " ya dummy";
            Debug.Log(collider.gameObject.tag);
        }
    }
}
