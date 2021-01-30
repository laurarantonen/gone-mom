using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnController : MonoBehaviour
{

    public string goToAisleScene;
    private bool playerInsideTrigger;

    public void Update()
    {
        if(playerInsideTrigger && Input.GetKeyDown(KeyCode.W)){
            SceneManager.LoadScene(goToAisleScene);
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
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        playerInsideTrigger = false;
    }
}
