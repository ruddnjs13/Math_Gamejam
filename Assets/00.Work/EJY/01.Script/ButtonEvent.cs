using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public GameObject problemPanel;
    public void OnStart()
    {
        problemPanel.SetActive(true);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnClose()
    {
        problemPanel.SetActive(false);
    }

    public void SceneChanger(int i)
    {
        SceneManager.LoadScene(i);
    }
}
