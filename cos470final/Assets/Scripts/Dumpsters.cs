using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dumpsters : MonoBehaviour
{
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
        Debug.Log("We in the method");
        Debug.Log(collider.gameObject.tag == "crate");
        if (collider.gameObject.tag == "crate") {
            
            Destroy(collider.gameObject);
        }
    }
}
