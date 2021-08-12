using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    private GameManager gameManager;

    // This array tracks the % of found colors, and if they are considered discovered.
    public int[,] statusArray = new int[216, 2];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Progress Array: " + statusArray[2, 0]);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateProgress(int index, int percent)
    {
        if (percent > statusArray[index, 0])
        {
            statusArray[index, 0] = percent;
            if(percent > 60)
            {
                statusArray[index, 1] = 1;
            }
        }
    }

}
