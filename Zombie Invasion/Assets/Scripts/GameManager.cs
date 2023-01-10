using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isDead;
    public GameObject StartScene;
    public bool IsGameActive;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        IsGameActive = true;
    }
   public void StartGame()
    {
        StartScene.gameObject.SetActive(false);
    }
}
