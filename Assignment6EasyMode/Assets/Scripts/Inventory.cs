using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<InventoryItem>();
    }
}
