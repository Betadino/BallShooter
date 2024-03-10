using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using UnityEngine.SocialPlatforms.Impl;

public class GenerateBawls : MonoBehaviour
{
    public GameObject go;
    float timer;

    // Update is called once per frame
    void Update()
    {
        
        timer+=Time.deltaTime;
        if(timer>3)
        {
            SpawnBawl();
            timer = 0;
        }

       
    }

    void SpawnBawl() {
        Vector3 rv = new Vector3(Random.Range(-0.5f, .5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Instantiate(go, rv, Quaternion.identity);
    }


}
