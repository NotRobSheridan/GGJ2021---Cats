using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterGenerator : MonoBehaviour
{

    public GameObject realAnimal;
    public GameObject gameManager;
    public SpriteRenderer bodyTypeSprite, earsTypeSprite, extrasTypeSprite, eyesTypeSprite, legsTypeSprite, tailTypeSprite;
    public SpriteRenderer bodyIDSprite, earsIDSprite, extrasIDSprite, eyesIDSprite, legsIDSprite, tailIDSprite;


    AnimalPartsManager partsScript;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        partsScript = gameManager.GetComponent<AnimalPartsManager>();
    }

    public void CreateLetter()
    {
        bodyIDSprite.sprite = partsScript.correctBody.idSprite;
        earsIDSprite.sprite = partsScript.correctEars.idSprite;
        extrasIDSprite.sprite = partsScript.correctExtras.idSprite;
        eyesIDSprite.sprite = partsScript.correctEyes.idSprite;
        legsIDSprite.sprite = partsScript.correctLegs.idSprite;
        tailIDSprite.sprite = partsScript.correctTail.idSprite;

        bodyTypeSprite.sprite = partsScript.correctBody.typeSprite;
        earsTypeSprite.sprite = partsScript.correctEars.typeSprite;
        extrasTypeSprite.sprite = partsScript.correctExtras.typeSprite;
        eyesTypeSprite.sprite = partsScript.correctEyes.typeSprite;
        legsTypeSprite.sprite = partsScript.correctLegs.typeSprite;
        tailTypeSprite.sprite = partsScript.correctTail.typeSprite;


        Debug.Log("Creating Letter");
    }
}
