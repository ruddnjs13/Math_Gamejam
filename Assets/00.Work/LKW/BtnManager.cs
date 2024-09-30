using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{
    public void BtnClick(int answerIndex)
    {
        if (answerIndex == QuizManager.instance.answerIndex)
        {
            Debug.Log("맞음");
        }
        else
        {
            Debug.Log("늘림");
        }
    }
}
