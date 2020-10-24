using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameState : MonoBehaviour , IState
{

   

    [SerializeField] private GameObject _pauseScreen;
    private Button resumeButton;
    
    public void Enter()
    {
        _pauseScreen.SetActive(true);
        resumeButton = _pauseScreen.GetComponentInChildren<Button>();
        resumeButton.onClick.AddListener(HandlePauseButton);
        Time.timeScale = 0f;
    }

    public void Exit()
    {
        _pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }


    private void HandlePauseButton()
    {
       // GameManager.Instance.SetState(StateType.GameState);
    }

    
}
