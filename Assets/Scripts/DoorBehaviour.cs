using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DoorBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject lookedDoor;
    [SerializeField] private GameObject UnlookingDoor;
    private GameObject pickedGO =null;
    private InventaryItems inventoryItems;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventoryItems = FindObjectOfType<InventaryItems>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        pickedGO = ObtainGOPicked();
        if(Input.GetKey("e")){
        }
        if(other.gameObject.CompareTag("Key") )
        {
            if(Input.GetKey("e")){
                if(pickedGO.name == "Key1"){
                    UnlookingDoor.SetActive(true);
                    Destroy(this.gameObject);
                } else {
                   lookedDoor.SetActive(false);
                   lookedDoor.SetActive(true);
                }
                
                
            }
            }
            else {
                lookedDoor.SetActive(false);
                lookedDoor.SetActive(true);

            }
    }

    private GameObject ObtainGOPicked()
{
    if (inventoryItems != null && inventoryItems.getPickedObject() != null)
    {
        return inventoryItems.getPickedObject();
    }
    return null;
}
    }

