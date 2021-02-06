using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListUI : MonoBehaviour
{
    private AudioSource itemAudio;
    public GameObject[] items;

    public void Start()
    {
        itemAudio = GetComponent<AudioSource>();
    }

    public void CrossItem(int itemNumber)
    {
        itemAudio.Play();
        Debug.Log("Cross item" + itemNumber);
        items[itemNumber-1].gameObject.SetActive(true);
    }

    public void DestroyList()
    {
        Destroy(gameObject);
    }

}
