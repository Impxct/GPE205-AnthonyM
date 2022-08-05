using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class PlayerController : Controller
{
    public KeyCode MoveForwardKey;
    public KeyCode MoveBackwardKey;
    public KeyCode RotateClockwiseKey;
    public KeyCode RotateCounterClockwiseKey;
    public KeyCode shootKey;
    // Start is called before the first frame update
        
    public override void Start()
    {
        //if we have a GameManager
        if (GameManager.instance != null) {
            // And it tracks the player(s)
            if (GameManager.instance.players != null) {
                // Register with the GameManager
                GameManager.instance.players.Add(this);
            }
        }
        //run start() function from the parent (base) class
        base.Start();   
    }

    // Update is called once per frame
    public override void Update()
    {
        //process our keyboard inputs
        ProcessInputs();

        //Run the Update() function from the parent base class
        base.Update();
    }

    public void OnDestroy()
    {
        // If we have a GameManager
        if (GameManager.instance != null) {
            // And it tracks the player(s)
            if (GameManager.instance.players != null) {
                // Deregister with the GameManager
                GameManager.instance.players.Remove(this);
            }
        }
    }

    public override void ProcessInputs()
    {
        if (Input.GetKey(MoveForwardKey))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(MoveBackwardKey))
        {
            pawn.MoveBackward();
        }
        
        if (Input.GetKey(RotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(RotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
        
        if (Input.GetKeyDown(shootKey))
        {
            pawn.Shoot();
        }
    }
}
