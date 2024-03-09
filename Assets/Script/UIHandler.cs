using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler: MonoBehaviour
{
    
    public static void SyncLives(TMP_Text hp){
        hp.SetText(Convert.ToString(GameState.life));
    }

    public static void SyncStats(TMP_Text points,TMP_Text shots){

         shots.SetText(Convert.ToString(GameState.shotsFired));
         points.SetText(Convert.ToString(GameState.score));
    }
}
