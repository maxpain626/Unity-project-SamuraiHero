using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5 },
            {"Antidote", 7 },
            {"Aspirin", 1 }
        };
        //Debug.LogFormat("Items: {0}", itemInventory.Count);
        //itemInventory.Add("Throwing Knife", 3);
        //itemInventory["Potion"] = 10;
        //Debug.LogFormat("Items: {0}", itemInventory.Count);

        foreach(KeyValuePair<string, int>kvp in itemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }

    //void Update()
    //{
        
    //}
}
