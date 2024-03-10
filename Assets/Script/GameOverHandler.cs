using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Subject.SetScore();        
    }

    public void Reload(){
        Subject.Reload();
    }
}
