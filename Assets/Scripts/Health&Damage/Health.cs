using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour

{
    public float currentHealth;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        //Set health to max
        currentHealth = maxHealth;
        //health cant go past 0
        currentHealth = Mathf.Clamp (currentHealth, 0, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //HEAL FUNC
    public void useHeal(float amount)
    {
        currentHealth = currentHealth + amount;
    }

            //take damage here
        public void TakeDamage (float amount, Pawn source)
    {
        currentHealth = currentHealth - amount;
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);
        // checks to see if health is <= 0 here
        if (currentHealth <= 0) {
            Die (source);
        }
    }

    //Death func
    public void Die (Pawn source)
    {
        Destroy(gameObject);
    }
}
