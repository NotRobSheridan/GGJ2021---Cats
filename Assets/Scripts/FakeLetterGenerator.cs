using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLetterGenerator : MonoBehaviour
{
    public SpriteRenderer[] idSprites;
    public Sprite[] typeSprites;
    int randomNum;

    public void Awake()
    {
        CreateFakeLetter();
    }

    public void CreateFakeLetter()
    {
        foreach(SpriteRenderer rend in idSprites)
        {
            randomNum = Random.Range(0, 11);
            rend.sprite = typeSprites[randomNum];

        }
    }
}
