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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            
            if(UnityEngine.Input.GetMouseButtonDown(0))
            { 
                
                if(hit.collider.CompareTag("ball")){
                    Destroy(hit.collider.gameObject);
                    Subject.ChangeScore(10);
                }
            }            
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);


    }

    
}
