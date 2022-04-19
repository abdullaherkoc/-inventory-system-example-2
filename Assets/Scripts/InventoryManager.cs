using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryManager : MonoBehaviour
{

    public static InventoryManager instance; 
    [SerializeField] public Slot selectedSlot;
    public ItemSr holdingItem;
    [SerializeField] private ItemSr selectedItem;
    
    public Image carryingItem;
  
 

    public Slot SelectedSlot
    {
        get
        {
           return selectedSlot;
        }
        set
        {
            if (selectedItem != null)
            {
                var tempItem = value.HoldingItem;
                value.HoldingItem = selectedItem;
                selectedSlot.HoldingItem = tempItem;
                selectedItem = null;
                carryingItem.color = new Color(0, 0, 0, 0);
                selectedSlot = null;
                return;
            }
            selectedSlot = value;
            if (selectedItem == null)
            {
                if (selectedSlot.HoldingItem != null)
                {
                    selectedItem = selectedSlot.HoldingItem;
                    carryingItem.color = new Color(1, 1, 1, 1);
                    carryingItem.sprite = selectedItem.ItemIcon;
                    selectedSlot.HoldingItem = null;
                }
            }
        }
    }

    private void Awake()
    {
        
        instance = this;
    }


    private void Update()
    {
        carryingItem.transform.position = Input.mousePosition;

    }


}
