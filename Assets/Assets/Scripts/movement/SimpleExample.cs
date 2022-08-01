using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour
{
    // test string for theText
    public string theText = "Hello World";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //writes value "theText" ("Hello World") to the console window
        Debug.Log(theText);
    }
}
