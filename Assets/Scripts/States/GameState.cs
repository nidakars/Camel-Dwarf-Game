using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour, IState
{
   // [SerializeField] private PlayerController _player;
    [SerializeField] private GameObject _pauseButtonGMO;
    private Button _pauseButton;
    GameManager gm;
    public void Enter()
    {
        Debug.Log("Entered Game state");
        //if (!_player)
        //{
        //    Debug.LogError("PlayerController yok");
        //}

       
        _pauseButtonGMO.SetActive(true);
        _pauseButton = _pauseButtonGMO.GetComponentInChildren<Button>();
        _pauseButton.onClick.AddListener(HandlePauseButton);
     
        
            
            
        // _player.enabled = true;
        //_player.SetCallBack(StopGameLoop);
     

       
    }

    public void Exit()
    {
        _pauseButtonGMO.SetActive(false);
    }

    private void StopGameLoop()
    {
       // _player.Reset();
       // _player.enabled = false;
    }

    private void HandlePauseButton()
    {
      gm.SetState(StateType.PauseGameState);
    }
}
