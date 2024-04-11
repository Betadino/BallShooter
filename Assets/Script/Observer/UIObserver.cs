using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;


//classe em MonoBehaviour para ter acesso imediato aos labels.
public class UIObserver : MonoBehaviour
{
    //everything with GO is for GameOver screen.
    public TMP_Text hp, score, scoreGO, shots, shotsGO;
    public GameObject canvas, canvasGO;
    
    private void Start()
    {
        // Find the subject object and subscribe to its event
            Subject.gameStart += Lives;
            Subject.gameOver += HandleGameOver;
            Subject.changeLives +=Lives;
            Subject.changeScore += IFinallyHitSomething;
            Subject.setScore += SetScore;
            Subject.reload += GameReload;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the events 
            Subject.gameStart -= Lives;
            Subject.gameOver -= HandleGameOver;
            Subject.changeLives -=Lives;
            Subject.changeScore -= IFinallyHitSomething;
            Subject.setScore -= SetScore;
            Subject.reload -= GameReload;

    }


    private void HandleGameOver()
    {
       Camera.main.GetComponent<GenerateBawls>().enabled = false;
       canvas.SetActive(false);
       canvasGO.SetActive(true);
       
    }

    private void Lives()
    {
       UIHandler.SyncLives(hp);
    }

    private void IFinallyHitSomething(int i){
        //not using "int i" here for now, just in the signature 
        //so it stops whining and not making me another action on the Subject.CS
        //future proof if i want to give different points to different objects
        UIHandler.SyncStats(score);
    }

    private void SetScore()
    {
      UIHandler.SyncStats(scoreGO, shots);
    }
    
     private void GameReload()
     {
        GameInit.game.SetState(new RunningState());
        canvasGO.SetActive(false);
        canvas.SetActive(true);
        Camera.main.GetComponent<GenerateBawls>().enabled = true;
     }
}
