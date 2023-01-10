using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health = 10;
    private bool isDead;
    private bool GameOver;
    public bool IsGameActive;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;  
    }

   public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0 && !isDead && !GameOver)
        {
            isDead = true;
            GameOver = true;
            Debug.Log("Dead");
            IsGameActive = false;
        }
    }
}
