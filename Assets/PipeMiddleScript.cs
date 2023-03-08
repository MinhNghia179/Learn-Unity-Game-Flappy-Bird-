using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    public int scoreToAdd = 1;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        logic.addScore(scoreToAdd);
    }    
}
