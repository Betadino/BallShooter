using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGO : MonoBehaviour
{

    public TextMeshPro points, shots;
    
    // Start is called before the first frame update
    void Start()
    {
        shots.SetText(Convert.ToString(GameState.shotsFired));
        points.SetText(Convert.ToString(GameState.score));
    }

}
