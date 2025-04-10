using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LampBehaviour : MonoBehaviour
{
    private bool lightIsOn = false;
    public GameObject lamp;
    public Canvas interactionCanvas;
    private bool playerNearby = false;
    public TextMeshProUGUI tBoton;
    public TextMeshProUGUI tlightIsOn;
    public Light myLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightIsOn = false;
        if (interactionCanvas != null) interactionCanvas.enabled = false;
        if (tBoton != null) tBoton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "Hand")
        {
            playerNearby = true;
            if (interactionCanvas != null)

                interactionCanvas.enabled = true;
                if(lightIsOn == true){
                    tBoton.text = "G";
                    tlightIsOn.text = "Apagar";
                }
                if(lightIsOn == false){
                    tBoton.text = "F";
                    tlightIsOn.text = "Encender";
                }

            if (tBoton != null)
                tBoton.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && !lightIsOn)
            {
                myLight.enabled = true;
                lightIsOn = true;
                Debug.Log("Encendiendo luz");
            }
            if (Input.GetKeyDown(KeyCode.G) && lightIsOn)
            {
                myLight.enabled = false;
                lightIsOn = false;
                Debug.Log("Encendiendo luz");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Hand")
        {
            playerNearby = false;

            if (interactionCanvas != null)
                interactionCanvas.enabled = false;

            if (tBoton != null)
                tBoton.gameObject.SetActive(false);
        }
    }
}
