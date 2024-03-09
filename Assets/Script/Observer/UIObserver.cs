using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIObserver : MonoBehaviour
{
    public TextMeshPro hp;
    
    private void Start()
    {
        // Find the subject object and subscribe to its event
         
        
            Subject.gameOver += HandleGameOver;
            Subject.changeLives +=Lives;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed
         
            Subject.gameOver -= HandleGameOver;
            Subject.changeLives -=Lives;
    }


    private void HandleGameOver()
    {
       SceneHandler.LoadScene("GO");
    }

    private void Lives()
    {
       UIGP.SyncLives(hp);
    }
    
}
