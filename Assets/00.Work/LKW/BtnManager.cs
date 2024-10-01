using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BtnManager : MonoBehaviour
{
    [SerializeField] private GameObject _wronPanel;
    [SerializeField] private GameObject _selectPanel;
    
    public void BtnClick(int answerIndex)
    {
        if (answerIndex == QuizManager.instance.answerIndex)
        {
            if (QuizManager.instance._quizIndex == 39)
            {
                QuizManager.instance.GameClear();
                return;
            }
            QuizManager.instance._quizIndex++;
            ScoreManager.instance.SetScore(++ScoreManager.instance.currentScore);
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
    public void NextBtn1()
    {
        QuizManager.instance.GameOver();
    }
    

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
