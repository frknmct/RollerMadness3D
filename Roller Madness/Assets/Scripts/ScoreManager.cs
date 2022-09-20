using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private Text scoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        UpdateTheScore();
    }

    private void UpdateTheScore()
    {
        scoreText.text = "Skor: " + score.ToString();
    }
}
