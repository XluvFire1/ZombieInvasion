using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDead : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public bool isDead;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
            playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
