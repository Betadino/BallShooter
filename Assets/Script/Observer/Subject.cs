using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class Subject : MonoBehaviour
{


   
    public static event Action setScore , reload , changeLives , changeShots , gameOver, gameStart;
    public static event Action<int> changeScore;

    //para passar instancia bola e o objeto a destruir por referencia
    public static event Action<Ball,GameObject> explosion, killed;

    
    
    

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

    public static void Explosion(Ball ball, GameObject go)
    {   
        explosion?.Invoke(ball, go);
    }
     public static void Killed(Ball ball,GameObject go)
    {   
        killed?.Invoke(ball, go);
    }
    
    
    
}
