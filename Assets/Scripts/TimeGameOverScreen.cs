using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeGameOverScreen : MonoBehaviour
{
    public float initialTime = 120f;
    private float currentTime;
    // Start is called before the first frame update
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
        else if (currentTime <= 0)
        {
         
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
