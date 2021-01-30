using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int itemsHeld = 0;
    
    public void Awake() 
    { 
        DontDestroyOnLoad(gameObject); 
    }

    public int getItemCount()
    {
        return itemsHeld;
    }

    public void addItem()
    {
        itemsHeld++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("itemcount on" + itemsHeld);
        }
    }
}
