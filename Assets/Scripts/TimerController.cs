using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
   public float initialTime = 120f;
    private float currentTime;
    public gameMangerScript gameManager;
    private bool isReached;

    public TextMeshProUGUI timerText;

    void Start()
    {
        currentTime = initialTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else if(currentTime <= 0)
        {
            isReached = true;
            gameManager.gameOver();
            Debug.Log("Time's up!");
        }
    }

    void UpdateTimerDisplay()
    {
        float minutes = Mathf.Floor(currentTime / 60);
        float seconds = Mathf.RoundToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
