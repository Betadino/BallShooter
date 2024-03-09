using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class GPObserver : MonoBehaviour
{
    private void Start()
    {
        // Find the subject object and subscribe to its event
         
            Subject.gameStart += GameInitVar;
            Subject.changeScore += ChangeScore;
            Subject.changeShots += ChangeShots;
            Subject.changeLives += ChangeLives;
        
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed
         
            Subject.changeScore -= ChangeScore;
            Subject.changeShots -= ChangeShots;
            Subject.changeLives -= ChangeLives;
    }


    private void ChangeScore(int points)
    {
       GameState.score+=points;
    }
    private void ChangeShots()
    {
       ++GameState.shotsFired;
    }
    private void ChangeLives()
    {
       --GameState.life;
    }

     private void GameInitVar(){
        GameState.shotsFired = 0;
        GameState.spheresKilled = 0;
        GameState.score = 0;
        GameState.life =2;
     }

}
