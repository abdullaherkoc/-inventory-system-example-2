using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Nesneolustur : MonoBehaviour
{

    public List<ItemSr> items = new List<ItemSr>();
    public List<Slot> slots = new List<Slot>();
    public Image yeniobje;
    public ItemSr newItem;
    public int r;

    public void GenerateItemAndReplace()
    {
        List<Slot> emptySlots = new List<Slot>();
        try
        {
            emptySlots = slots.FindAll(x => x.HoldingItem == null);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
            return;
        }

        if (emptySlots.Count <= 0)
        {
            Debug.Log("Tum Slotlar dolu");
            return;
        }

         r = Random.Range(0, items.Count - 1);
         newItem = Instantiate(items[r]);

        emptySlots.First().HoldingItem = newItem;


    }


    private void Awake()
    {
      
    }
    private void LateUpdate()
    {
      
        yeniobje.sprite = newItem.ItemIcon;

    }



}
