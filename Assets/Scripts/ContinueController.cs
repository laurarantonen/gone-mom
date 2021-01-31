using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueController : MonoBehaviour
{

    public string goToAisleScene;
    public AudioSource audiosource;
    private bool playerInsideTrigger;
    private SceneFader sceneFader;

    public void Start()
    {
        sceneFader = FindObjectOfType<SceneFader>();
    }
    public void Update()
    {
        audiosource = GetComponent<AudioSource>();
        if(playerInsideTrigger && Input.GetKeyDown(KeyCode.A)){
            sceneFader.FadeToLevel();
            audiosource.Play();
            Invoke("GoToScene", 3f);
        }
    }
    
    void GoToScene()
    {
        SceneManager.LoadScene(goToAisleScene);
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