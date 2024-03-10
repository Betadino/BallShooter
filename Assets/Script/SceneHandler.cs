using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public static void LoadSceneSingle(string s)
    {
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }

    public static void LoadSceneAdd(string s)
    {
        SceneManager.LoadScene(s, LoadSceneMode.Additive);
    }

    
}