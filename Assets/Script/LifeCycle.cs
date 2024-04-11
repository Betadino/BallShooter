using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeCycle : MonoBehaviour
{
    
    Ball ball = new();
    void Start()
    {   
        //set state, envia a ball para poder manipular no OnEnterState e o go para poder destruir depois
        //uma cadeia de acontecimentos complexa, mas desnecessária, provando o conceito de usar statemachine + observer
        ball.SetState(new BallAliveState(), ball, gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        ball.Update();
    }


    
}
