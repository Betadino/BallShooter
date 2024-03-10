using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class UIObserver : MonoBehaviour
{
    public TMP_Text hp, score, shots;
    
    private void Start()
    {
        // Find the subject object and subscribe to its event
         
            Subject.gameStart += Lives;
            Subject.gameOver += HandleGameOver;
            Subject.changeLives +=Lives;
            Subject.changeScore += IFinallyHitSomething;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed
            Subject.gameStart -= Lives;
            Subject.gameOver -= HandleGameOver;
            Subject.changeLives -=Lives;

    }


    private void HandleGameOver()
    {
       Camera.main.GetComponent<GenerateBawls>().enabled = false;
       SceneHandler.LoadSceneAdd("GO");
       
    }

    private void Lives()
    {
       UIHandler.SyncLives(hp);
    }

    private void IFinallyHitSomething(int i){
        //not using "int i" here, just in the signature 
        //so it stops whining and not making me another action on the Subject.CS
        UIHandler.SyncStats(score);
    }
    
}
