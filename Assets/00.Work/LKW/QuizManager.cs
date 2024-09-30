using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] public List<QuizSO> quizList;
    [SerializeField] private Image _quizInfo;
    [SerializeField] private TextMeshProUGUI _answer1;
    [SerializeField] private TextMeshProUGUI _answer2;
    [SerializeField] private TextMeshProUGUI _answer3;
    [SerializeField] private TextMeshProUGUI _answer4;
    [SerializeField] private GameObject _gameClearPanel;
    [SerializeField] private GameObject _gameOverPanel;
    public int answerIndex;
    public int _quizIndex;

    public static QuizManager instance;

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
        answerIndex = quizList[_quizIndex].answerIndex;
        _quizInfo.sprite = quizList[_quizIndex].quizInfo;
        _answer1.text = quizList[_quizIndex].answer1;
        _answer2.text = quizList[_quizIndex].answer2;
        _answer3.text = quizList[_quizIndex].answer3;
        _answer4.text = quizList[_quizIndex].answer4;
    }

    public void SetNewQuiz()
    {
        answerIndex = quizList[_quizIndex].answerIndex;
        _quizInfo.sprite = quizList[_quizIndex].quizInfo;
        _answer1.text = quizList[_quizIndex].answer1;
        _answer2.text = quizList[_quizIndex].answer2;
        _answer3.text = quizList[_quizIndex].answer3;
        _answer4.text = quizList[_quizIndex].answer4;
    }

    public void GameClear()
    {
        _gameClearPanel.SetActive(true);
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
    }
}
