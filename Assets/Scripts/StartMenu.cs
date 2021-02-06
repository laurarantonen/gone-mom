using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private SceneFader sceneFader;
    private void Start()
    {
        sceneFader = FindObjectOfType<SceneFader>();
    }

   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("OpeningScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

   void GoToNext()
   {
       sceneFader.FadeToLevel();
   }
}

