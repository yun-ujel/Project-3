using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ColourController : MonoBehaviour
{
    [SerializeField] private ColourType colourType;
    [SerializeField] private ColourType outlineType;

    [HideInInspector] public Outline outline;
    [HideInInspector] public Image image;
    [HideInInspector] public RawImage rawImage;
    [HideInInspector] public TextMeshProUGUI text;

    private void Awake()
    {
        // Assign UI Graphic Reference
        if (outline == null)
        {
            TryGetComponent(out outline);
        }
        if (image == null && rawImage == null && text == null)
        {
            TryGetComponent(out image);
            TryGetComponent(out rawImage);
            TryGetComponent(out text);
        }
    }
    private enum ColourType
    {
        tone0,
        tone1,
        tone2,
        tone3,
        tone4,
        tone5,
        outline,
        wildCard,
        none
    }

    void OnColourUpdate(Colour8 colour8)
    {
        if (colourType != ColourType.none)
        {
            ChangeColour(colour8);
        }
        if (outline != null && outlineType != ColourType.none)
        {
            ChangeOutline(colour8);
        }
        
    }

    void ChangeGraphic(Color colour)
    {
        if (image != null)
        {
            image.color = colour;
        }
        else if (rawImage != null)
        {
            rawImage.color = colour;
        }
        else if (text != null)
        {
            text.color = colour;
        }
    }

    void ChangeColour(Colour8 colour8)
    { 
        if (colourType == ColourType.tone0)
        {
            ChangeGraphic(colour8.Tone0);
        }
        else if (colourType == ColourType.tone1)
        {
            ChangeGraphic(colour8.Tone1);
        }
        else if (colourType == ColourType.tone2)
        {
            ChangeGraphic(colour8.Tone2);
        }
        else if (colourType == ColourType.tone3)
        {
            ChangeGraphic(colour8.Tone3);
        }
        else if (colourType == ColourType.tone4)
        {
            ChangeGraphic(colour8.Tone4);
        }
        else if (colourType == ColourType.tone5)
        {
            ChangeGraphic(colour8.Tone5);
        }
        else if (colourType == ColourType.outline)
        {
            ChangeGraphic(colour8.Outline);
        }
        else if (colourType == ColourType.wildCard)
        {
            ChangeGraphic(colour8.WildCard);
        }
    }

    void ChangeOutline(Colour8 colour8)
    {
        if (outlineType == ColourType.tone0)
        {
            outline.effectColor = colour8.Tone0;
        }
        else if (outlineType == ColourType.tone1)
        {
            outline.effectColor = colour8.Tone1;
        }
        else if (outlineType == ColourType.tone2)
        {
            outline.effectColor = colour8.Tone2;
        }
        else if (outlineType == ColourType.tone3)
        {
            outline.effectColor = colour8.Tone3;
        }
        else if (outlineType == ColourType.tone4)
        {
            outline.effectColor = colour8.Tone4;
        }
        else if (outlineType == ColourType.tone5)
        {
            outline.effectColor = colour8.Tone5;
        }
        else if (outlineType == ColourType.outline)
        {
            outline.effectColor = colour8.Outline;
        }
        else if (outlineType == ColourType.wildCard)
        {
            outline.effectColor = colour8.WildCard;
        }

        Debug.Log("Changed Outline Colour");
    }
}