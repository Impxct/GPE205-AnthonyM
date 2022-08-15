using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeking : MonoBehaviour
{
    public GameObject target;

    public void DoSeekState()
    {
        //seeks the target(pawn)
        Seek(target);
    }

    public void Seek (GameObject target)
    {
        //rotate towards target its seeking,
        pawn.RotateTowards(target.transform.position);
        //move towards target seeking
        pawn.MoveForward();
    }

    //rotatetowards here >>
    public override void RotateTowards(Vector3 targetPosition)
    {
        //finds vector of our target here>>
        Vector3 vectorToTarget = targetPosition - transform.position;
        //find rotation to look down vector>>
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);
        //rotate closer to vector, but keep at normal turn speed rate. (for frames)>>
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation. turnSpeed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
