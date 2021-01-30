using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private bool playerNearItem;
    public GameObject interactText;
    private GameController gameController;
    public int itemNumber;

    public void Start()
    {
        gameController = FindObjectOfType<GameController>();
        Debug.Log("item created");
    }

    public void Update()
    {

        if (gameController.getItemCount() != itemNumber)
        {
            Debug.Log("itemcount on" + gameController.getItemCount());
            gameObject.SetActive(false);
        }
        
        if(playerNearItem && Input.GetKeyDown(KeyCode.E)){
            gameController.addItem(); // add +1 to items held
            Debug.Log(gameController.getItemCount());
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerNearItem = true; //if player is near an interactable item
            interactText.SetActive(true); // prompt player with text
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerNearItem = false; //if player is near an interactable item
            interactText.SetActive(false); // prompt player with text
        }
    }
}
