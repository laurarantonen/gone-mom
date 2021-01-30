using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private bool playerNearItem;
    public GameObject interactText;
    private PlayerStatus playerStatus;

    public void Start()
    {
        playerStatus = FindObjectOfType<PlayerStatus>();

    }

    public void Update()
    {
        if(playerNearItem && Input.GetKeyDown(KeyCode.E)){
            playerStatus.addItem(); // add +1 to items held
            Debug.Log(playerStatus.getItemCount());
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerNearItem = true; //if player is near an interactable item
            interactText.SetActive(true); // prompt player with text
        }

        else
        {
            interactText.SetActive(false);
        }
    }
}
