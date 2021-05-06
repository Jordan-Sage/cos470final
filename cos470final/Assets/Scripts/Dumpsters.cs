using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dumpsters : MonoBehaviour
{
    public GameObject theBin;

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
        Debug.Log("Dumpster on Trigger method");
        Debug.Log(collider.gameObject.tag == "crate");
        if (collider.gameObject.tag == "crate") {
            
            Destroy(collider.gameObject);

           Instantiate(theBin, new Vector3(0,0,-4), Quaternion.identity);

        }
    }
}
