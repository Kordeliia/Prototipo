using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventaryItems : MonoBehaviour
{
    public List<Image> uiInventorySpace1;
    public List<Image> uiInventorySpace2;

    public List<GameObject> gOGenerated;
    public GameObject handPoint;
    private GameObject objectUI1 = null;
    private GameObject objectUI2 = null;

    private bool freeHoleInv1 = true, freeHoleInv2 = true;
    private GameObject pickedObject = null;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("1") && freeHoleInv1 == false && pickedObject == null){
                UseInventoryItem(objectUI1, 1);
                freeHoleInv1 = true;

            }
            if(Input.GetKey("2") && freeHoleInv2 == false && pickedObject == null){
                UseInventoryItem(objectUI2, 2);
                freeHoleInv2 = true;
            }
           if(Input.GetKey("r") && pickedObject != null){
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;

            }
    }
   void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Key")){
            if(Input.GetKey("f") && (freeHoleInv1 == true || freeHoleInv2 == true)){
                if(freeHoleInv1 == true)
                {
                    switch (other.gameObject.name)
                    {
                        case "Key1":
                            objectUI1 = gOGenerated[0].gameObject;
                            uiInventorySpace1[0].gameObject.SetActive(true);
                            freeHoleInv1 = false;
                            other.gameObject.SetActive(false);
                            pickedObject = null;
                            break;
                        case "Key2":
                            objectUI1 = gOGenerated[1].gameObject;
                            uiInventorySpace1[0].gameObject.SetActive(true);
                            freeHoleInv1 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "KeyBlack":
                            objectUI1 = gOGenerated[2].gameObject;
                            uiInventorySpace1[2].gameObject.SetActive(true);
                            freeHoleInv1 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "FirstAid":
                            objectUI1 = gOGenerated[3].gameObject;
                            uiInventorySpace1[3].gameObject.SetActive(true);
                            freeHoleInv1 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "Water":
                            objectUI1 = gOGenerated[4].gameObject;
                            uiInventorySpace1[4].gameObject.SetActive(true);
                            freeHoleInv1 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
    }
                } else if (freeHoleInv2 == true)
                {
                    switch (other.gameObject.name)
                    {
                        case "Key1":
                            objectUI2 = gOGenerated[0].gameObject;
                            uiInventorySpace2[0].gameObject.SetActive(true);
                            freeHoleInv2 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "Key2":
                            objectUI2 = gOGenerated[1].gameObject;
                            uiInventorySpace2[0].gameObject.SetActive(true);
                            freeHoleInv2 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "KeyBlack":
                            objectUI2 = gOGenerated[2].gameObject;
                            uiInventorySpace2[2].gameObject.SetActive(true);
                            freeHoleInv2 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "FirstAid":
                            objectUI2 = gOGenerated[3].gameObject;
                            uiInventorySpace2[3].gameObject.SetActive(true);
                            freeHoleInv2 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;
                        case "Water":
                            objectUI2 = gOGenerated[4].gameObject;
                            uiInventorySpace2[4].gameObject.SetActive(true);
                            freeHoleInv2 = false;
                            Destroy(other.gameObject);
                            pickedObject = null;
                            break;

                }
                
            }
        }
    }
    }
    void UseInventoryItem(GameObject itemIventary, int number){
        GameObject newObject = null;
        Debug.Log("Generando Objeto:" + number);
        if(number == 1){
            
            switch (itemIventary.gameObject.name)
                    {
                        case "Key1":
                            newObject = Instantiate(gOGenerated[0], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Key1";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace1[0].gameObject.SetActive(false);
                            pickedObject = newObject;
                            break;
                        case "Key2":
                            newObject = Instantiate(gOGenerated[1], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Key2";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace1[0].gameObject.SetActive(false);
                            pickedObject = newObject;
                            break;
                        case "KeyBlack":
                            newObject = Instantiate(gOGenerated[2], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="KeyBlack";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace1[2].gameObject.SetActive(false);
                            pickedObject = newObject;
                            break;
                        case "FirstAid":
                            newObject = Instantiate(gOGenerated[3], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="FirstAid";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace1[3].gameObject.SetActive(false);
                            break;
                        case "Water":
                           newObject = Instantiate(gOGenerated[4], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Water";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace1[4].gameObject.SetActive(false);
                            break;
                }
        } else if(number ==2){
            switch (itemIventary.gameObject.name)
                    {
                        case "Key1":
                            newObject = Instantiate(gOGenerated[0], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Key1";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace2[0].gameObject.SetActive(false);
                            break;
                        case "Key2":
                           newObject = Instantiate(gOGenerated[1], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Key2";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace2[0].gameObject.SetActive(false);
                            break;
                        case "KeyBlack":
                            newObject = Instantiate(gOGenerated[2], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="KeyBlack";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace2[2].gameObject.SetActive(false);
                            break;
                        case "FirstAid":
                            newObject = Instantiate(gOGenerated[3], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="FirstAid";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace2[3].gameObject.SetActive(false);
                            break;
                        case "Water":
                            newObject = Instantiate(gOGenerated[4], handPoint.gameObject.transform.position, handPoint.gameObject.transform.rotation);
                            newObject.GetComponent<Rigidbody>().useGravity = false;
                            newObject.GetComponent<Rigidbody>().isKinematic = true;
                            newObject.gameObject.transform.SetParent(handPoint.gameObject.transform);
                            newObject.gameObject.name ="Water";
                            pickedObject = newObject.gameObject;
                            uiInventorySpace2[4].gameObject.SetActive(false);
                            break;
                }
        }
    }

    public GameObject getPickedObject(){
        return pickedObject;
    }
    }
