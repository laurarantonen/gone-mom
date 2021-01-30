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
}
