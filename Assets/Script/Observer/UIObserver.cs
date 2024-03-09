using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIObserver : MonoBehaviour
{
    public TMP_Text? hp, score, shots;
    
    private void Start()
    {
        // Find the subject object and subscribe to its event
         
            Subject.gameStart += Lives;
            Subject.gameOver += HandleGameOver;
            Subject.changeLives +=Lives;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed
            Subject.gameStart += Lives;
            Subject.gameOver -= HandleGameOver;
            Subject.changeLives -=Lives;
    }


    private void HandleGameOver()
    {
       SceneHandler.LoadScene("GO");
       UIHandler.SyncStats(score, shots);
    }

    private void Lives()
    {
       UIHandler.SyncLives(hp.GetComponent<TMP_Text>());
    }
    
}
