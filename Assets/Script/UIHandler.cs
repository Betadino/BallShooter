using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler: MonoBehaviour
{
    //sync changes of the game variables to UI.
    public static void SyncLives(TMP_Text hp){
        hp.SetText(Convert.ToString(GameData.life));
    }

    public static void SyncStats(TMP_Text points,TMP_Text shots){

         shots.SetText(Convert.ToString(GameData.shotsFired));
         points.SetText(Convert.ToString(GameData.score));
    }

    //Overloading SyncStats baby
    public static void SyncStats(TMP_Text points)
    {
        points.SetText(Convert.ToString(GameData.score));
    }
}
