using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scorePanel;
    
    public static ScoreManager instance;
    public int currentScore { get; set; } = 0;

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _scorePanel.text = currentScore.ToString();
    }


    public void SetScore(int nextSocre)
    {
        _scorePanel.text = nextSocre.ToString();
    }
    
}
