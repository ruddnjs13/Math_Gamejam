using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BtnManager : MonoBehaviour
{
    [SerializeField] private GameObject _wronPanel;
    [SerializeField] private GameObject _selectPanel;
    
    public void BtnClick(int answerIndex)
    {
        if (answerIndex == QuizManager.instance.answerIndex)
        {
            QuizManager.instance._quizIndex++;
            ScoreManager.instance.SetScore(ScoreManager.instance.currentScore++);
            _selectPanel.SetActive(true);
            Debug.Log("맞음");
        }
        else
        {
            Debug.Log("틀림");
            _wronPanel.SetActive(false);
        }
    }

    public void NextBtn()
    {
        QuizManager.instance.SetNewQuiz();
        _wronPanel.SetActive(false);
        _selectPanel.SetActive(false);
    }
}
