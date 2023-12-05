using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
   public float initialTime = 120f;
    private float currentTime;
    public gameMangerScript gameManager;
    private bool playerIsActive = true;
    public TextMeshProUGUI timerText;

    void Start()
    {
        ExitTrigger.isReached = false;
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
      
        else if(currentTime > 0 && ExitTrigger.isReached == true)
        {
            gameManager.gameOver();
            Debug.Log("You Win");
        }
        else if (currentTime <= 0 && ExitTrigger.isReached == false)
        {
            currentTime = 0;
            gameManager.gameOver();
            Debug.Log("Time's up!");
            
        }
    }

    void UpdateTimerDisplay()
    {
        if(playerIsActive)
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
