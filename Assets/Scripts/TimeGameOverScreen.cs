using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeGameOverScreen : MonoBehaviour
{
    public float initialTime = 120f;
    private float currentTime;
    private bool playerIsActive = true;
    public TextMeshProUGUI timerText;

    void Start()
    {
        currentTime = initialTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (currentTime > 0 && ExitTrigger.isReached == false)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }

        else if (currentTime > 0 && ExitTrigger.isReached == true)
        {
           
            Debug.Log("You Win");
        }
        else if (currentTime <= 0 && ExitTrigger.isReached == false)
        {
            Debug.Log("Time's up!");
        }
    }

    void UpdateTimerDisplay()
    {
        if (playerIsActive)
        {
            if (currentTime >= 0)
            {
                float minutes = Mathf.Floor(currentTime / 60);
                float seconds = Mathf.RoundToInt(currentTime % 60);

                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }

    }
}
