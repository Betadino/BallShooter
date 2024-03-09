using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class Subject : MonoBehaviour
{
    // Declare event for notifying observers

    public static event Action gameStart;
    public static event Action gameOver;
    public static event Action changeShots;
    public static event Action changeLives;
    public static event Action<int> changeScore;
    
    
    

    // Notifies all observers when an event occurs
    

    public static void GameStart()
    {   
        gameStart?.Invoke();
    }
    public static void GameOver()
    {   
        gameOver?.Invoke();
    }
    public static void ChangeLives()
    {   
        changeLives?.Invoke();
    }
    public static void ChangeScore(int points)
    {   
        changeScore?.Invoke(points);
    }
    
    public static void ChangeShots()
    {   
        changeShots?.Invoke();
    }
    
    
}
