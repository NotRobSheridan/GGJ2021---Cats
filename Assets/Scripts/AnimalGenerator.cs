using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour
{
    public GameObject gameManager;
    //public GameObject head, ears, extra, eyes, legs, tail;
    public SpriteRenderer bodySprite, earsSprite, extrasSprite, eyesSprite, legsSprite, tailSprite;
    AnimalPartsManager partsScript;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        partsScript = gameManager.GetComponent<AnimalPartsManager>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    public void GenerateAnimal()
    {
        partsScript.CreateAnimal();
        bodySprite.sprite = partsScript.correctBody.partSprite;
        earsSprite.sprite = partsScript.correctEars.partSprite;
        extrasSprite.sprite = partsScript.correctExtras.partSprite;
        eyesSprite.sprite = partsScript.correctEyes.partSprite;
        legsSprite.sprite = partsScript.correctTail.partSprite;
        tailSprite.sprite = partsScript.correctLegs.partSprite;
        //Debug.Log(partsScript.correctEars.partType);

        foreach(SpriteRenderer rend in GetComponentsInChildren<SpriteRenderer>())
        {
            rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); ;
        }
    }
}
