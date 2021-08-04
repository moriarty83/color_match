using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Material material;
    private Color32 colorToMatch;
     
    // Start is called before the first frame update
    void Start()
    {
        material = this.gameObject.GetComponent<Renderer>().material;
        NewMatchColor();
        
    }

    // Creates a random color and applies it to the Sphere
    public void NewMatchColor()
    {
        colorToMatch = Random.ColorHSV();
        material.color = colorToMatch;
        // Debug.Log(color.r);
        
    }

    // TODO Come up with a better scoring method.
    // Returns a single number represneting the absolute values of the RGB values
    // subtracted from 255. The closer the clicked and matched colors are, the higher value is returned.
    // Kept in the sphere script so the Sphere color can remain private.
    public int compareColors(Color32 clickedColor)
    {
        int rAbsolute = Mathf.Abs(255 - (Mathf.Abs(colorToMatch.r - clickedColor.r)));
        int gAbsolute = Mathf.Abs(255 - (Mathf.Abs(colorToMatch.g - clickedColor.g)));
        int bAbsolute = Mathf.Abs(255 - (Mathf.Abs(colorToMatch.b - clickedColor.b)));

        Debug.Log("Clicked Color: " + clickedColor);
        Debug.Log("Color to Match: " + colorToMatch);


        return (rAbsolute + gAbsolute + bAbsolute)*100 / (255*3);
    }
}
