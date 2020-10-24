using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PreGameState : MonoBehaviour, IState
{
    [SerializeField] private GameObject _waitScreen;
    [SerializeField] private TextMeshProUGUI _waitText;


   

    private bool _isWaitingToStart;
    private Coroutine _coroutine;



    public void Enter()
    {
        Debug.Log("pregame state");
     

        _isWaitingToStart = true;

        
        _coroutine = StartCoroutine(WaitForStart());
        _waitScreen.SetActive(true);

    }



    public void Exit()
    {
        _isWaitingToStart = false;
        StopCoroutine(_coroutine);
        _waitScreen.SetActive(false);
    }

    private void Update()
    {
       if(Input.GetKeyUp(KeyCode.Space))
        {
            FindObjectOfType<GameManager>().SetState(StateType.GameState);
        }
    }


    private IEnumerator WaitForStart()
    {
        float t = 0;

        while (_isWaitingToStart)
        {
            var val = Mathf.PingPong(t, 0.5f) + 0.5f;
            _waitText.color = new Color(1, 1, 1, val);
            yield return null;
            t += Time.deltaTime;
        }
    }
}
