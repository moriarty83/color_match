using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject swatchParent;
    public GameObject swatchPrefab;

    public Sprite checkMark;

    private GameObject[] swatches;

    private ColorPallet colorPallet;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        colorPallet = gameManager.colorPallet;

        showSwatches();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showSwatches()
    {
        for (int i = 0; i < 200; i++)
        {
            GameObject newSwatch = GameObject.Instantiate(swatchPrefab);
            newSwatch.transform.SetParent(swatchParent.transform, false);
            newSwatch.GetComponentsInChildren<Image>()[1].color = gameManager.colorPallet.netscapeColors[i];

        }
    }
}
