using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour
{
    public GameObject gameManager;
    public SpriteRenderer bodySprite, earsSprite, extrasSprite, eyesSprite, legsSprite, tailSprite;
    AnimalPartsManager partsScript;
    Color randomColor;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        partsScript = gameManager.GetComponent<AnimalPartsManager>();
    }

    // Update is called once per frame
    public void GenerateAnimal()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        partsScript.CreateAnimal();
        bodySprite.sprite = partsScript.correctBody.partSprite;
        earsSprite.sprite = partsScript.correctEars.partSprite;
        extrasSprite.sprite = partsScript.correctExtras.partSprite;
        eyesSprite.sprite = partsScript.correctEyes.partSprite;
        legsSprite.sprite = partsScript.correctTail.partSprite;
        tailSprite.sprite = partsScript.correctLegs.partSprite;
        randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); ;
        foreach (SpriteRenderer rend in GetComponentsInChildren<SpriteRenderer>())
        {
            rend.material.color = randomColor;
        }
    }
}
