using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PictureRotation : MonoBehaviour
{
    private bool isOffTheHook = false;
    private float zRotation = 0f;
    private float yInicial;
    private float xInicial;

    public Image bHint1;
    public Image bHint2;
    public GameObject picture;
    public Canvas interactionCanvas;
    private bool playerNearby = false;
    public TextMeshProUGUI tBoton;
    public TextMeshProUGUI tIsOffTheHook;

    void Start()
    {
        isOffTheHook = false;
        yInicial = transform.eulerAngles.y;
        xInicial = transform.eulerAngles.x;

        if (interactionCanvas != null) interactionCanvas.enabled = false;

        if (bHint1 != null) bHint1.gameObject.SetActive(false);
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "Hand")
        {
            playerNearby = true;
            if (interactionCanvas != null)

                interactionCanvas.enabled = true;
                if(isOffTheHook == true){
                    tBoton.text = "G";
                    tIsOffTheHook.text = "Colgar";
                }
                if(isOffTheHook == false){
                    tBoton.text = "F";
                    tIsOffTheHook.text = "Descolgar";
                }

            if (bHint1 != null)
                bHint1.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && !isOffTheHook)
            {
                zRotation += 45f;
                transform.localRotation = Quaternion.Euler(xInicial, yInicial, zRotation);
                isOffTheHook = true;
                Debug.Log("Rotando en Z el cuadro: " + zRotation);
            }

            if (Input.GetKeyDown(KeyCode.G) && isOffTheHook)
            {
                zRotation -= 45f;
                transform.localRotation = Quaternion.Euler(xInicial, yInicial, zRotation);
                isOffTheHook = false;
                Debug.Log("Colocando cuadro: " + zRotation);
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

            if (bHint1 != null)
                bHint1.gameObject.SetActive(false);
        }
    }
}