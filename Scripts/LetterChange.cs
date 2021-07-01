using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterChange : MonoBehaviour
{
    public Sprite[] Letters;
    public Sprite CurrentSprite;
    public Image OurImage;
    public static int RightLetter;

    private void Start()
    {
        SpriteChange();
    }

    private void SpriteChange()
    {
        RightLetter = Random.Range(0, 25);
        CurrentSprite = Letters[RightLetter];
        OurImage.sprite = CurrentSprite;
    }
}
