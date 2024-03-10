using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeCycle : MonoBehaviour
{
    //Responsible for the TTL of balls. Deduction of player lives if not hit and died instead.
    float timer;
    // Start is called before the first frame update
    void Start()
    {   
       
        timer = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        DeadBawl();
    }

    void DeadBawl(){
        if(timer<0)
        {
            Destroy(gameObject);
            Subject.ChangeLives();
            if (GameState.life == 0)
            {
                Subject.GameOver();
            }
            
        }
    }
    
}
