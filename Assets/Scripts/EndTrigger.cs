using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private SceneFader sceneFader;

    public void Start()
    {
        sceneFader = FindObjectOfType<SceneFader>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hello");
            sceneFader.FadeToLevel();
            Invoke("GoToScene", 2f);
        }
    }
    
    void GoToScene()
    {
        SceneManager.LoadScene("EndingScene");
    }
    
    
}
