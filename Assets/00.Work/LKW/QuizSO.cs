using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Quiz")]
public class QuizSO : ScriptableObject
{
   public string quizInfo;
   public string answer1;
   public string answer2;
   public string answer3;
   public string answer4;

   public int answerIndex;
}
