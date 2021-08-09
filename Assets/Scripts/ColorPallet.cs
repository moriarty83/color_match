using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPallet
{
    public Color32[] netscapeColors = {new Color32(0,0,0,255), new Color32(0,0,51,255), new Color32(0,0,102,255),
        new Color32(0,0,153,255), new Color32(0,0,204,255), new Color32(0,0,255,255), new Color32(0,51,0,255),
        new Color32(0,51,51,255), new Color32(0,51,102,255), new Color32(0,51,153,255), new Color32(0,51,204,255),
        new Color32(0,51,255,255), new Color32(0,102,0,255), new Color32(0,102,51,255), new Color32(0,102,102,255),
        new Color32(0,102,153,255), new Color32(0,102,204,255), new Color32(0,102,255,255), new Color32(0,153,0,255),
        new Color32(0,153,51,255), new Color32(0,153,102,255), new Color32(0,153,153,255), new Color32(0,153,204,255),
        new Color32(0,153,255,255), new Color32(0,204,0,255), new Color32(0,204,51,255), new Color32(0,204,102,255),
        new Color32(0,204,153,255), new Color32(0,204,204,255), new Color32(0,204,255,255), new Color32(0,255,0,255),
        new Color32(0,255,51,255), new Color32(0,255,102,255), new Color32(0,255,153,255), new Color32(0,255,204,255),
        new Color32(0,255,255,255), new Color32(51,0,0,255), new Color32(51,0,51,255), new Color32(51,0,102,255),
        new Color32(51,0,153,255), new Color32(51,0,204,255), new Color32(51,0,255,255), new Color32(51,51,0,255),
        new Color32(51,51,51,255), new Color32(51,51,102,255), new Color32(51,51,153,255), new Color32(51,51,204,255),
        new Color32(51,51,255,255), new Color32(51,102,0,255), new Color32(51,102,51,255), new Color32(51,102,102,255),
        new Color32(51,102,153,255), new Color32(51,102,204,255), new Color32(51,102,255,255), new Color32(51,153,0,255),
        new Color32(51,153,51,255), new Color32(51,153,102,255), new Color32(51,153,153,255), new Color32(51,153,204,255),
        new Color32(51,153,255,255), new Color32(51,204,0,255), new Color32(51,204,51,255), new Color32(51,204,102,255),
        new Color32(51,204,153,255), new Color32(51,204,204,255), new Color32(51,204,255,255), new Color32(51,255,0,255),
        new Color32(51,255,51,255), new Color32(51,255,102,255), new Color32(51,255,153,255), new Color32(51,255,204,255),
        new Color32(51,255,255,255), new Color32(102,0,0,255), new Color32(102,0,51,255), new Color32(102,0,102,255),
        new Color32(102,0,153,255), new Color32(102,0,204,255), new Color32(102,0,255,255), new Color32(102,51,0,255),
        new Color32(102,51,51,255), new Color32(102,51,102,255), new Color32(102,51,153,255), new Color32(102,51,204,255),
        new Color32(102,51,255,255), new Color32(102,102,0,255), new Color32(102,102,51,255), new Color32(102,102,102,255),
        new Color32(102,102,153,255), new Color32(102,102,204,255), new Color32(102,102,255,255), new Color32(102,153,0,255),
        new Color32(102,153,51,255), new Color32(102,153,102,255), new Color32(102,153,153,255), new Color32(102,153,204,255),
        new Color32(102,153,255,255), new Color32(102,204,0,255), new Color32(102,204,51,255), new Color32(102,204,102,255),
        new Color32(102,204,153,255), new Color32(102,204,204,255), new Color32(102,204,255,255), new Color32(102,255,0,255),
        new Color32(102,255,51,255), new Color32(102,255,102,255), new Color32(102,255,153,255), new Color32(102,255,204,255),
        new Color32(102,255,255,255), new Color32(153,0,0,255), new Color32(153,0,51,255), new Color32(153,0,102,255),
        new Color32(153,0,153,255), new Color32(153,0,204,255), new Color32(153,0,255,255), new Color32(153,51,0,255),
        new Color32(153,51,51,255), new Color32(153,51,102,255), new Color32(153,51,153,255), new Color32(153,51,204,255),
        new Color32(153,51,255,255), new Color32(153,102,0,255), new Color32(153,102,51,255), new Color32(153,102,102,255),
        new Color32(153,102,153,255), new Color32(153,102,204,255), new Color32(153,102,255,255), new Color32(153,153,0,255),
        new Color32(153,153,51,255), new Color32(153,153,102,255), new Color32(153,153,153,255), new Color32(153,153,204,255),
        new Color32(153,153,255,255), new Color32(153,204,0,255), new Color32(153,204,51,255), new Color32(153,204,102,255),
        new Color32(153,204,153,255), new Color32(153,204,204,255), new Color32(153,204,255,255), new Color32(153,255,0,255),
        new Color32(153,255,51,255), new Color32(153,255,102,255), new Color32(153,255,153,255), new Color32(153,255,204,255),
        new Color32(153,255,255,255), new Color32(204,0,0,255), new Color32(204,0,51,255), new Color32(204,0,102,255),
        new Color32(204,0,153,255), new Color32(204,0,204,255), new Color32(204,0,255,255), new Color32(204,51,0,255),
        new Color32(204,51,51,255), new Color32(204,51,102,255), new Color32(204,51,153,255), new Color32(204,51,204,255),
        new Color32(204,51,255,255), new Color32(204,102,0,255), new Color32(204,102,51,255), new Color32(204,102,102,255),
        new Color32(204,102,153,255), new Color32(204,102,204,255), new Color32(204,102,255,255), new Color32(204,153,0,255),
        new Color32(204,153,51,255), new Color32(204,153,102,255), new Color32(204,153,153,255), new Color32(204,153,204,255),
        new Color32(204,153,255,255), new Color32(204,204,0,255), new Color32(204,204,51,255), new Color32(204,204,102,255),
        new Color32(204,204,153,255), new Color32(204,204,204,255), new Color32(204,204,255,255), new Color32(204,255,0,255),
        new Color32(204,255,51,255), new Color32(204,255,102,255), new Color32(204,255,153,255), new Color32(204,255,204,255),
        new Color32(204,255,255,255), new Color32(255,0,0,255), new Color32(255,0,51,255), new Color32(255,0,102,255),
        new Color32(255,0,153,255), new Color32(255,0,204,255), new Color32(255,0,255,255), new Color32(255,51,0,255),
        new Color32(255,51,51,255), new Color32(255,51,102,255), new Color32(255,51,153,255), new Color32(255,51,204,255),
        new Color32(255,51,255,255), new Color32(255,102,0,255), new Color32(255,102,51,255), new Color32(255,102,102,255),
        new Color32(255,102,153,255), new Color32(255,102,204,255), new Color32(255,102,255,255), new Color32(255,153,0,255),
        new Color32(255,153,51,255), new Color32(255,153,102,255), new Color32(255,153,153,255), new Color32(255,153,204,255),
        new Color32(255,153,255,255), new Color32(255,204,0,255), new Color32(255,204,51,255), new Color32(255,204,102,255),
        new Color32(255,204,153,255), new Color32(255,204,204,255), new Color32(255,204,255,255), new Color32(255,255,0,255),
        new Color32(255,255,51,255), new Color32(255,255,102,255), new Color32(255,255,153,255), new Color32(255,255,204,255),
        new Color32(255,255,255,255)
    };

    private Color32 selectedColor;

    public Color32 RandomColor()
    {

        return (this.netscapeColors[Random.Range(0, netscapeColors.Length - 1)]);
    }

    public void SelectRandomColor()
    {
        this.selectedColor = this.netscapeColors[Random.Range(0, netscapeColors.Length - 1)];
    }

}
