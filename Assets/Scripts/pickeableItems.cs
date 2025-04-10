using UnityEngine;
using UnityEngine.UI;
public class pickeableItems : MonoBehaviour
{
     public GameObject handPoint;
    private GameObject pickedObject = null;
    //private GameObject objectUI = null;
    public Image uiInventoryObject;

 //   private bool itemInInventory= false;
    public GameObject objectInventoryGenerated;

    void Update()
    {
        
            if(Input.GetKey("r") && pickedObject != null){
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
            }

    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("ObjectsSimples") ){
            if(Input.GetKey("e") && pickedObject == null){
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
            }
            }
 
    }
    }

