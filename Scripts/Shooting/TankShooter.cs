using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : Shooter
{
    public Transform firepointTransform;

    // Start is called before the first frame update
    public override void Start()
    {
    }

    // Update is called once per frame
    public override void Update()
    { 
    }

    public override void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float lifespan)
    {
        //Instantiate projectile here
        GameObject newShell = Instantiate(shellPrefab, firepointTransform.position, firepointTransform.rotation) as GameObject;
        //DamageOnHit component
        DamageOnHit doh = newShell.GetComponent<DamageOnHit>();
        //null if it has one
        if (doh != null)
        {
            //set damageDone in the doh component to value passed in -->
            doh.damageDone = damageDone;
            //set owner to pawn of fired shell, if there is one. owner is null otherwise.
            doh.owner = GetComponent<Pawn>();
        }
        //Get rb component here -->
        Rigidbody rb = newShell.GetComponent<Rigidbody>();
        //if it has one -->
        if (rb != null)
        {
            //add force to move it forward here -->
            rb.AddForce(firepointTransform.forward * fireForce);
        }
        //destroy after a certain time (shell wont fly infinitley)
        Destroy(newShell, lifespan);
    }
}
