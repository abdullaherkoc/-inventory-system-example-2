using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "New Item")]
public class ItemSr : ScriptableObject
{
    public ItemType ItemType = ItemType.Weapon;
    public Sprite ItemIcon;

    [Range(0, 100)]
    public int Damage = 0;

    [Range(0, 100)]
    public int Armor = 0;

    [Range(0, 100)]
    public int ConsumeHealthPower = 0;

    [Range(0, 1000)]
    public int Cost = 100;

}
