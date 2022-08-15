using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller
{
    public enum AIState { Guard, Chase, Flee, Patrol, Attack, Scan, BackToPost };
    public AIState currentState;
    private float lastStateChangeTime;

    // Start is called before the first frame update
    public override void Start()
    {
        //Run the parent start
        base.Start();   
    }

    // Update is called once per frame
    public override void Update()
    {
        //make decisions
        MakeDecisions();
        //run the parent update
        base.Update();
    }

    public void MakeDecisions()
    {
        switch (currentState) {
            case AIState.Guard:
            //guards
            //check for transitions.
            break;
            case AIState.Chase:
            //chases
            //check for transitions
            break;
            case AIState.Flee:
            //flees
            //check for transitions
            break;
            case AIState.Patrol:
            //Patrols
            //check for transitions
            break;
            case AIState.Attack:
            //Attacks
            //check for transitions
            break;
            case AIState.Scan:
            //Scans
            //check for transitions
            break;
            case AIState.BackToPost:
            //Returns to post or Guard (maybe)
            //check for transitions
            break;
        }
        Debug.Log("Making Decisions");
    }

    public virtual void ChangeState (AIState newState)
    {
        //changes state
        currentState = newState;
        //save the time when states change
        lastStateChangeTime = Time.time;
    }
}
