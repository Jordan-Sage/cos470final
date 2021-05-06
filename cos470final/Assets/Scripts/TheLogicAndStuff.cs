using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheLogicAndStuff : MonoBehaviour
{

    public Text displayText;
    public int cans = 0;
    public int bottles = 0;
    public int glass = 0;
    public static TheLogicAndStuff _instance;

    void Awake() {
        if (_instance == null) {
        _instance = this;
        } else {
        Destroy(gameObject);
        }
    }
    
    public static TheLogicAndStuff GetInstance() {
        return TheLogicAndStuff._instance;
    }

}
