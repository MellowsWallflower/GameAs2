using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreGameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    // Start is called before the first frame update
    private static scoreGameOverScreen _instance;

    public static scoreGameOverScreen Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<scoreGameOverScreen>();

                if (_instance == null)
                {
                    GameObject scoreManagerObject = new GameObject("ScoreManager");
                    _instance = scoreManagerObject.AddComponent<scoreGameOverScreen>();
                }
            }

            return _instance;
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
