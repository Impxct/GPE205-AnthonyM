using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    //pawn&float
    public float damageDone;
    public Pawn owner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //trigger function
    public void OnTriggerEnter(Collider other)
    {
        //Get health componenet from game object with collider being overlapped.
        Health otherHealth = other.gameObject.GetComponent<Health>();
        //only damage if it has Health comp
        if (otherHealth != null)
        {
            //do damage here
            otherHealth.TakeDamage(damageDone, owner);
        }

        //Destroy ourselves... damaged or not
        Destroy(gameObject);
    }
}
