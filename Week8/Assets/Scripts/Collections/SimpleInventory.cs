using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class SimpleInventory : MonoBehaviour
{
    //1. Generic List Declaration
    private List<string> playerItems = new List<string>();
    public TextMeshProUGUI inventoryText;

    void Start()
    {
        //2. Create(Adding Items)
        playerItems.Add("Fire Sword");
        playerItems.Add("Health Potion");
    }

    public void AddItem(string itemName)
    {
        playerItems.Add(itemName);
        UpdateUI();
    }

    public void RemoveItem(string itemName)
    {
        //3. Remove Items
        if (playerItems.Remove(itemName))
        {
            Debug.Log($"Removed {itemName} from Inventory!");
        }
        else
        {
            Debug.LogWarning("Item Not Found!");
        }
        UpdateUI();
    }

    //Drop items when player dies
    public void RemoveItemDrop()
    {
        //Loop Backwards from end to 0
        for (int i = playerItems.Count -1; i>=0; i--)
        {
            if (playerItems[i].Contains("Potion"))
            {
                playerItems.RemoveAt(i);
            }
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        //Update Inventory
        inventoryText.text = "Inventirt Contents: \n";
        for (int i = 0; i < playerItems.Count; i++)
        {
            inventoryText.text += $"- {playerItems[i]}\n";
        }
    }

}
