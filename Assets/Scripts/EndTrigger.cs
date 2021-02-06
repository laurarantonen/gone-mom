using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private SceneFader sceneFader;
    private MusicPlayer musicPlayer;
    private ItemListUI itemListUI;

    public void Start()
    {
        sceneFader = FindObjectOfType<SceneFader>();
        itemListUI = FindObjectOfType<ItemListUI>();
        musicPlayer = FindObjectOfType<MusicPlayer>();
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
        itemListUI.DestroyList();
        musicPlayer.DestroyMusicPlayer();
        SceneManager.LoadScene("EndingScene");
    }
    
    
}
