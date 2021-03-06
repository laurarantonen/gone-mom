﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
        //PlayMusic();
    }
 
   public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

   public void DestroyMusicPlayer()
   {
       Destroy(gameObject);
   }
 
    /*public void StopMusic()
    {
        audioSource.Stop();
    }*/
}
