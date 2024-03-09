using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGP: MonoBehaviour
{

    public TextMeshPro lives;
    // Start is called before the first frame update
    void Start()
    {
        
        lives = GetComponent<TextMeshPro>();
        lives.SetText(Convert.ToString(GameState.life));
    }


    public static void SyncLives(TextMeshPro lives){
        lives.SetText(Convert.ToString(GameState.life));
    }
}
