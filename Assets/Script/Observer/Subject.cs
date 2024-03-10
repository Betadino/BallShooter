using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class Subject : MonoBehaviour
{
    // Declare event for notifying observers

   
    public static event Action setScore , reload , changeLives , changeShots , gameOver, gameStart;
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

    public static void SetScore()
    {   
        setScore?.Invoke();
    }

    public static void Reload()
    {   
        reload?.Invoke();
    }
    
    
}
