using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public gameMangerScript gameManager;
    private bool isReached;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !isReached)
        {
            Debug.Log("Player reached the exit!");
            isReached = true;
            gameManager.gameOver();

        }
    }
}