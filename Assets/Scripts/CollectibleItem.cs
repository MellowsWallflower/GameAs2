using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
            Collect2();
        }
    }

    private void Collect()
    {
        ScoreManager.Instance.IncreaseScore(scoreValue);
        gameObject.SetActive(false);
    }

    private void Collect2()
    {
        scoreGameOverScreen.Instance.IncreaseScore(scoreValue);
        gameObject.SetActive(false);
    }
}
