using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
  public GameObject Enemy;
  void OnCollisionEnter2D(Collision2D otherObj)
    {
        if(otherObj.gameObject.tag == "enemy")
        {
            Destroy(gameObject, .5f);
        }
    }
}