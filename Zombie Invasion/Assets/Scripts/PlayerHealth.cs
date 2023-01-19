using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health = 10;
    public bool isDead;
    public bool IsGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        health = maxHealth;  
    }

   public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0 && !isDead)
        {
            isDead = true;
            Debug.Log("Dead");
            IsGameActive = false; 
        }
    }
}
