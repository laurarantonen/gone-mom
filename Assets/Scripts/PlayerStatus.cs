using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private int itemsHeld = 0;

    public int getItemCount()
    {
        return itemsHeld;
    }

    public void addItem()
    {
        itemsHeld++;
    }
}
