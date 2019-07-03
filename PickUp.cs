using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    
  
    public Text countText;
    public Text winText;
   

  
    public int count;
    /// <summary>
    ///inventory الجزء المسؤل عن
    
     
   GameObject inventoryPanel;
  GameObject slotPanel;

    public GameObject inventoryInt;
    public GameObject inventoryVariable;
    public GameObject inventoryEqal;
    public GameObject inventoryFive;
    public GameObject inventoryPlus;
    public GameObject inventorySix;
    public GameObject inventory;
    public GameObject inventory19;
    public GameObject inventory65;
    public GameObject inventory84;




    public GameObject [] slots;
   /// </summary>

    void Start()
    {
        

        count = 0;
        SetCountText();
        winText.text = "";
     
        
    }
   
    void OnTriggerEnter(Collider other)
    {
                if (other.gameObject.CompareTag("int"))
                {
                    other.gameObject.SetActive(false);

                    inventoryPanel = GameObject.Find("SlotPanel");
                    slotPanel = inventoryPanel.transform.Find("int").gameObject;
                    slots[0]=(Instantiate(inventoryInt));
                    slots[0].transform.SetParent(slotPanel.transform);
                    count++;
                }
                if (other.gameObject.CompareTag("Z"))
                {

                    other.gameObject.SetActive(false);
                    inventoryPanel = GameObject.Find("SlotPanel");
                    slotPanel = inventoryPanel.transform.Find("z").gameObject;
                    slots[1]=(Instantiate(inventoryVariable));
                    slots[1].transform.SetParent(slotPanel.transform);
                    count++;
                }
                if (other.gameObject.CompareTag("equl"))
                {
          
                    other.gameObject.SetActive(false);
                    inventoryPanel = GameObject.Find("SlotPanel");
                    slotPanel = inventoryPanel.transform.Find("=").gameObject;
                    slots[2]=(Instantiate(inventoryEqal));
                    slots[2].transform.SetParent(slotPanel.transform);
                    count++;
                }
                if (other.gameObject.CompareTag("X"))
                {
          
                    other.gameObject.SetActive(false);
                    inventoryPanel = GameObject.Find("SlotPanel");
                    slotPanel = inventoryPanel.transform.Find("x").gameObject;
                    slots[3]=(Instantiate(inventoryFive));
                    slots[3].transform.SetParent(slotPanel.transform);
                    count++;
                }
                if (other.gameObject.CompareTag("plus"))
                {
            
                    other.gameObject.SetActive(false);
                    inventoryPanel = GameObject.Find("SlotPanel");
                    slotPanel = inventoryPanel.transform.Find("+").gameObject;
                    slots[4]=(Instantiate(inventoryPlus));
                    slots[4].transform.SetParent(slotPanel.transform);
                    count++;
                }
        if (other.gameObject.CompareTag("Y"))
        {
            other.gameObject.SetActive(false);
            inventoryPanel = GameObject.Find("SlotPanel");
            slotPanel = inventoryPanel.transform.Find("y").gameObject;

            slots[5] = (Instantiate(inventorySix));
            slots[5].transform.SetParent(slotPanel.transform);
            count++;
        }
       
        

        if (other.gameObject.CompareTag(";"))
        {

            other.gameObject.SetActive(false);
            inventoryPanel = GameObject.Find("SlotPanel");
            slotPanel = inventoryPanel.transform.Find("Sime").gameObject;
            slots[6] = (Instantiate(inventory));
            slots[6].transform.SetParent(slotPanel.transform);
            count++;
        }
       
        SetCountText();
        if (other.gameObject.CompareTag("19"))
        {

            other.gameObject.SetActive(false);
            inventoryPanel = GameObject.Find("SlotPanel1");
            slotPanel = inventoryPanel.transform.Find("19").gameObject;
            slots[7] = (Instantiate(inventory19));
            slots[7].transform.SetParent(slotPanel.transform);
            count++;
        }




        if (other.gameObject.CompareTag("65"))
        {

            other.gameObject.SetActive(false);
            inventoryPanel = GameObject.Find("SlotPanel1");
            slotPanel = inventoryPanel.transform.Find("65").gameObject;
            slots[8] = (Instantiate(inventory65));
            slots[8].transform.SetParent(slotPanel.transform);
            count++;
        }

        if (other.gameObject.CompareTag("84"))
        {

            other.gameObject.SetActive(false);
            inventoryPanel = GameObject.Find("SlotPanel");
            slotPanel = inventoryPanel.transform.Find("84").gameObject;
            slots[9] = (Instantiate(inventory84));
            slots[9].transform.SetParent(slotPanel.transform);
            count++;
        }
    }
    public void SetCountText()
    {
        countText.text = "count" + count.ToString();    
        if (count == 8)
        {




            switch (count)
            {
                case 8:
                    winText.text = "You Win";
                    
                    break;
            }
               
            
        }
      
     
    }
   

   

}
