using UnityEngine;
using UnityEngine.UI;

public class ChangeFontSize : MonoBehaviour
{
    public Text textComponent;  // El objeto Text se debe asignar en el Inspector
    public int fontSizeStep = 2;
    public int minFontSize = 12;
    public int maxFontSize = 60;


    public void IncreaseFontSize()
    {
        if (textComponent != null && textComponent.fontSize < maxFontSize)
        {
            textComponent.fontSize += fontSizeStep;
        }
    }

    
    public void DecreaseFontSize()
    {
        if (textComponent != null && textComponent.fontSize > minFontSize)
        {
            textComponent.fontSize -= fontSizeStep;
        }
    }
}

