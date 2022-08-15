using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    //Variable for RoF
    public float fireRate;
    // Variable for move speed
    public float moveSpeed;
    // Variable for turn speed
    public float turnSpeed;
    //Variable to hold our Mover.
    public Mover mover;
    //Variable to hold our Shooter
    public Shooter shooter;
    //variable for our shell prefab
    public GameObject shellPrefab;
    //variable for our firing force
    public float fireForce;
    //variable for our dmg done
    public float damageDone;
    //variable for how long bullets fly if not colliding with anything (lifespan of rogue shells)
    public float shellLifespan;




    // Start is called before the first frame update
    public virtual void Start()
    {        
        mover = GetComponent<Mover>();
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    public virtual void Update()
    {       
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
    public abstract void RotateTowards(Vector3 targetPosition);
}