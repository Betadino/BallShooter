using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

//Handles all gamedata
public class GPObserver
{
    public void SubAll()
    {
        // Find the subject object and subscribe to its event   
            Subject.gameStart += GameInitVar;
            Subject.changeScore += ChangeScore;
            Subject.changeShots += ChangeShots;
            Subject.changeLives += ChangeLives;
            Subject.explosion += Explosion;
    }

    public void UnsubAll()
    {
        // Unsubscribe from the event when this object is destroyed
            Subject.gameStart -= GameInitVar;
            Subject.changeScore -= ChangeScore;
            Subject.changeShots -= ChangeShots;
            Subject.changeLives -= ChangeLives;
            Subject.explosion -= Explosion;
    }


    private void ChangeScore(int points)
    {
       GameData.score+=points;
    }
    private void ChangeShots()
    {
       ++GameData.shotsFired;
    }
    private void ChangeLives()
    {
       --GameData.life;
    }

     private void GameInitVar(){
        GameData.shotsFired = 0;
        GameData.spheresKilled = 0;
        GameData.score = 0;
        GameData.life =2;
     }

     private void Explosion(Ball ball, GameObject go)
     {
      ball.SetState(new BallExplodeState(), ball , go);
     }

     

}
