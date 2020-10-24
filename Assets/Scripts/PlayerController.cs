using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public Gamer _gamer;
    int _score=1;
    [SerializeField] public TextMeshProUGUI _scores;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void Sit()
    {
        anim.SetTrigger("isSitting");
        Debug.Log("cüce");
        
    }

    
    public void Stand()
    {

        anim.SetTrigger("isStanding");
        Debug.Log("deve");
    }

    // Update is called once per frame
    void Update()
    {
        if (_gamer._CDText.text == "Cüce") 
        {
            
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Sit();
                _score = _score + 1;
                _scores.text = _score.ToString();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {               
                    _scores.text = "Yanıldın";
                _gamer._CDText.text = "";
               
            }
            
        }
        else if (_gamer._CDText.text == "Deve")
        {  
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Stand();
                _score = _score + 1;
                _scores.text = _score.ToString();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            { _scores.text = "Yanıldın";
                _gamer._CDText.text = "";
            }
           
        }
        
    }

    public void Reset()
    {
        //sıfırla
    }

    private CallBack _dieCallBack;

    public void SetCallBack(CallBack callBack)
    {
        _dieCallBack = callBack;
    }



    /*internal void SetCallBack(object stopGameLoop)
    {
        throw new NotImplementedException();
    }*/
}
