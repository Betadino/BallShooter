using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeCycle : MonoBehaviour
{
   
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
        if(timer<0)
        {
            Destroy(gameObject);
            if (GameState.life == 0)
            {
                Subject.GameOver();
            }
            GameState.life -= 1;
        }
    }


    
}
