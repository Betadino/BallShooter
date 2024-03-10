using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
using static UnityEditor.PlayerSettings;

public class ClickNDestroy : MonoBehaviour
{
    //Provides the Functionaliity to kill them bawls.
    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            
            if(UnityEngine.Input.GetMouseButtonDown(0))
            { 
                Subject.ChangeShots();
                if(hit.collider.CompareTag("ball")){
                    Destroy(hit.collider.gameObject);
                    Subject.ChangeScore(10);
                }
            }            
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);

    }

}
