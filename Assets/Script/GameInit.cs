using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    //Init action that sets the game in motion.
    public GPObserver GPO=new();
    public static Game game=new();
    void Start()
    {
        GPO.SubAll();
        game.SetState(new RunningState());

        Debug.Log(GameData.life);
    }

    
}
