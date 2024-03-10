using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.Rendering;

using UnityEngine.UI;
public class UIObserverGameOver : MonoBehaviour
{
    public TMP_Text score, shots;
    
    private void Start()
    {
        // Find the subject object and subscribe to its event
            Subject.reload += GameReload;
            Subject.setScore += SetScore;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed
            Subject.setScore += SetScore;
            Subject.reload -= GameReload;
            
    }


    private void SetScore()
    {
      UIHandler.SyncStats(score, shots);
    }

    private void GameReload(){
        SceneHandler.LoadSceneSingle("Main");
    }

    

    
}
