using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gamer : MonoBehaviour

{
    [SerializeField] public TextMeshProUGUI _CDText;
    public float _spawnRate = 1f;
    public float _newSapwnTime;
     
    Gamer (TextMeshProUGUI CDText)
    {
        
        _CDText = CDText;
    }


    // Update is called once per frame
    void Update()
    {
        if(Time.time>=_newSapwnTime)
        {
            CamelORDwarf();
            _newSapwnTime=Time.time + 1f / _spawnRate;
        }
    }

    void Start()
    {

    }
   
    private void CamelORDwarf()
    {
        string[] cORd = new string[] { "Deve", "Cüce" };
        string randomCD = cORd[Random.Range(0, cORd.Length)];
        _CDText.text = randomCD;  
        _CDText.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f),1);
    }





    
}
