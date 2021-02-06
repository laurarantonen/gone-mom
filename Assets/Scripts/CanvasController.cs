using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public void Awake() 
    { 
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Toys")
        {
            GetComponent<CanvasGroup>().alpha = 1;
        }
    }
    
}
