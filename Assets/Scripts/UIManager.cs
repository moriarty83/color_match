using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;
    private ProgressTracker progressTracker;

    public GameObject progressUIParent;
    public GameObject swatchScrollRect;
    public GameObject swatchGridObject;
    public GameObject swatchPrefab;

    public GameObject sphere;

    public Sprite checkMark;

    private GameObject[] swatches;

    private ColorPallet colorPallet;

    private List<GameObject> swatchObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        toggleProgress();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        progressTracker = GameObject.Find("GameManager").GetComponent<ProgressTracker>();


        colorPallet = gameManager.colorPallet;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showProgress()
    {
        //progressUIParent.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width - 50, Screen.height - 50);
        //swatchScrollRect.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width - 100, Screen.height - 100);


        for (int i = 0; i < 200; i++)
        {
            GameObject newSwatch = GameObject.Instantiate(swatchPrefab);
            newSwatch.transform.SetParent(swatchGridObject.transform, false);
            newSwatch.GetComponentsInChildren<Image>()[1].color = gameManager.colorPallet.netscapeColors[i];
            newSwatch.GetComponentInChildren<Text>().text = progressTracker.statusArray[i, 0].ToString() + " %";
            swatchObjects.Add(newSwatch);

        }

        
        swatchGridObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width - 100, calculateScrollHeight());


    }

    public void clearSwatches()
    {
        for (int i = swatchObjects.Count-1; i >= 0; i--)
        {
            Destroy(swatchObjects[i]);
        }
    }

    private int calculateScrollHeight()
    {
         
        int count = 1;
        for (int i = 2; i < swatchGridObject.transform.childCount-1; i++)
        {
            if (swatchGridObject.GetComponentsInChildren<Transform>()[i].localPosition.y == swatchGridObject.GetComponentsInChildren<Transform>()[i - 1].localPosition.y)
            {
                count += 1;
            }
            else
            {
                break;
            }
        }
        Debug.Log("Count is" + count);
        return Mathf.RoundToInt(Mathf.Ceil(216 / 4 * 105));
    }

    public void toggleProgress()
    {
        if (progressUIParent.activeInHierarchy)
        {
            GameObject[] objectList = GameObject.FindGameObjectsWithTag("swatch");
            foreach(GameObject swatch in objectList)
            {
                Destroy(swatch);
            }
            sphere.GetComponent<MeshRenderer>().enabled = true;
            //gameManager.canClick = true;
            progressUIParent.SetActive(false);
            return;
        }
        else
        {
            sphere.GetComponent<MeshRenderer>().enabled = false;

            gameManager.canClick = false;
            progressUIParent.SetActive(true);
            showProgress();
            
        }
    }
}
