using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool gamePlaying;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;
    public void Start()
    {
        gamePlaying = false;
    }
   
    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    public void BeginGame()
    {
        gamePlaying = true;

        TimerController.instance.BeginTimer();
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
