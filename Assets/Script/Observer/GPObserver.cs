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
       ++GameState.shotsFired;
    }

}
