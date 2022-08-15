using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTImerTest : MonoBehaviour
{
    public float timerDelay = 1.0f;
    private float timeUntilNextEvent;
    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextEvent = timerDelay;
    }

    // Update is called once per frame
    void Update()
    {
    timeUntilNextEvent -= Time.deltaTime;
    if (timeUntilNextEvent <= 0)
    {
        Debug.Log("Its Me");
        timeUntilNextEvent = timerDelay;
    }
}
}
