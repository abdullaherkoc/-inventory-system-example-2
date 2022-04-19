using System;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image SlotImage;
    private Button button;
    public ItemType SlotType;
    public Action ItemChanged;
    [SerializeField] private ItemSr selectedItem;
    [SerializeField] private ItemSr holdingItem;

    

    public ItemSr HoldingItem
    {
        get { return holdingItem; }
        set
        {
            holdingItem = value;
            ItemChanged?.Invoke();
        }
    }

    private void Awake()
    {
        button = GetComponent<Button>();

        ItemChanged += OnItemChanged;
        button.onClick.AddListener(SelectSlot);
        SlotImage = GetComponent<Image>();
        if (HoldingItem != null)
            SlotImage.sprite = HoldingItem.ItemIcon;
    }

    private void OnItemChanged()
    {
        if (HoldingItem != null)
            SlotImage.sprite = HoldingItem.ItemIcon;
        else
            SlotImage.sprite = null;
    }

    public void SelectSlot()
    {
        InventoryManager.instance.SelectedSlot = this;

   
    }

}

public enum ItemType
{
    Inventory,
    Consumable,
    Weapon,
    Shield,
    Boots,
    Helmet,
    Belt
}