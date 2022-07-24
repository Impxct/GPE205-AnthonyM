using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForwardKey;
    public KeyCode MoveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;
    // Start is called before the first frame update
    public override void Start()
    {
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
    public override void ProcessInputs
    {
        if (Input.GetKey(MoveForwardKey))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(MoveBackwardKey))
        {
            pawn.MoveBackward();
        }
        
        if (Input.GetKey(rotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
    }
}
