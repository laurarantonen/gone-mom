using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private bool playerNearItem;
    private GameController gameController;
    private ItemListUI itemListUI;
    public int itemNumber;

    public void Start()
    {
        gameController = FindObjectOfType<GameController>();
        itemListUI = FindObjectOfType<ItemListUI>();
        Debug.Log("item created");
    }

    public void Update()
    {

        if (gameController.getItemCount() != itemNumber)
        {
            gameObject.SetActive(false);
        }
        
        if(playerNearItem && Input.GetKeyDown(KeyCode.E)){
            gameController.addItem(); // add +1 to items held
            itemListUI.CrossItem(gameController.getItemCount());
            Debug.Log("Item picked up, items held" + gameController.getItemCount());
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerNearItem = true; //if player is near an interactable item
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerNearItem = false; //if player is near an interactable item
        }
    }
}
