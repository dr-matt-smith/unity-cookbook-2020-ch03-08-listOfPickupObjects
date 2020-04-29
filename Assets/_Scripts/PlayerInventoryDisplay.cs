using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[RequireComponent(typeof(PlayerInventory))]
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text inventoryText;

    public void OnChangeInventory(List<PickUp> inventory)
    {
        // (1) clear existing display 
        inventoryText.text = "";

        // (2) build up new set of items  
        string newInventoryText = "carrying: ";
        int numItems = inventory.Count;
        for (int i = 0; i < numItems; i++)
        {
            string description = inventory[i].description;
            newInventoryText += " [" + description + "]";
        }

        // if no items in List then set string to message saying inventory is empty 
        if (numItems < 1)
            newInventoryText = "(empty inventory)";

        // (3) update screen display 
        inventoryText.text = newInventoryText;
    }
}
