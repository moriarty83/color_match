using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraImage : MonoBehaviour
{
// Camera display variables
    // rawimage is what the camera image is displayed on.
    public RawImage rawimage;
    // WebCamTextures are what get the image from the device camera.
    private WebCamTexture webCamTexture;

    // Sphere script

    private BallScript ballScript;

    // GameManager Script

    private GameManager gameManager;

    void Start()
    {
        ballScript = GameObject.Find("Sphere").GetComponent<BallScript>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        webCamTexture = new WebCamTexture();
        rawimage.texture = webCamTexture;
        rawimage.material.mainTexture = webCamTexture;
        rawimage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        webCamTexture.Play();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            
            Vector3 mousePosition = Input.mousePosition;
            
            Debug.Log(Input.mousePosition);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100f))
            {
                if(hit.transform.name == "Sphere")
                {
                    ballScript.NewMatchColor();
                    Debug.Log("You selected the " + hit.transform.name);
                    return;
                }

                if(hit.transform.name == "ProgressButton")
                {
                    GameObject.Find("GameManager").GetComponent<UIManager>().toggleProgress();
                    return;
                }
            }
            
            else if (gameManager.canClick)
            {
                Color32 clickedColor = webCamTexture.GetPixel((int)mousePosition.x, (int)mousePosition.y);
                gameManager.scoreAndContinue(ballScript.compareColors(clickedColor));
                Debug.Log(ballScript.compareColors(clickedColor));

            }
        }
    }



}

