using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class inventory : MonoBehaviour {

   GameObject inventoryPanel;
  GameObject slotPanel;

 public GameObject inventorySlot;
   public GameObject inventoryItem;

    int slotAmount;
   //public List<Set> items = new List<Set>();
   public List<GameObject> slots = new List<GameObject>();

	// Use this for initialization
	void Start () {
       slotAmount = 7;
        inventoryPanel = GameObject.Find("Inventory Panel");
        slotPanel = inventoryPanel.transform.Find("SlotPanel").gameObject;
        for(int i=0;i< slotAmount; i++)
        {
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
            
                slots.Add(Instantiate(inventoryItem));
            slots[i].transform.SetParent(slotPanel.transform);
        }
	}
	
}
