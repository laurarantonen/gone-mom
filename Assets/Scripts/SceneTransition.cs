using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string goToAisleScene;
    public string goForwardScene;
    private bool playerInsideTrigger;
    public GameObject guideText;
    public GameObject guideText2;
    public void Update()
    {
        if(playerInsideTrigger && Input.GetKeyDown(KeyCode.W)){
            SceneManager.LoadScene(goToAisleScene);
        }
        if(playerInsideTrigger && Input.GetKeyDown(KeyCode.A)){
            SceneManager.LoadScene(goForwardScene);
        }
    }

    public bool GetPlayerPosition()
    {
        return playerInsideTrigger;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerInsideTrigger = true;
            guideText.SetActive(true);
            guideText2.SetActive(true);
        }

        else
        {
            playerInsideTrigger = false;
            guideText.SetActive(false);
            guideText2.SetActive(false);
        }
    }
}
