using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject realLetter, fakeLetter;
    public SpriteRenderer bodySprite, earsSprite, extrasSprite, eyesSprite, legsSprite, tailSprite;
    public GameObject[] letterAnchors;

    GameObject currentPoint;
    int index;
    AnimalPartsManager partsScript;
    LetterGenerator generatorScript;
    Color randomColor;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        partsScript = gameManager.GetComponent<AnimalPartsManager>();
        generatorScript = realLetter.GetComponent<LetterGenerator>();
        GenerateAnimal();
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

        GenerateLetters();


    }

    public void GenerateLetters()
    {
        List<int> freeSpaces = new List<int>();
        for (int i = 0; i < 4; ++i)
        {
            freeSpaces.Add(i);
        }

        int randomIndex = Random.Range(0, freeSpaces.Count);
        int randomNumber = freeSpaces[randomIndex];
        freeSpaces.RemoveAt(randomIndex);

        GameObject[] fakeLetters = GameObject.FindGameObjectsWithTag("FakeLetter");
        foreach (GameObject fakeLetter in fakeLetters)
            GameObject.Destroy(fakeLetter);

        letterAnchors = GameObject.FindGameObjectsWithTag("LetterAnchor");
        index = /*Random.Range(0, freeSpaces.Count)*/randomNumber;
        currentPoint = letterAnchors[index];


        generatorScript.CreateLetter();
        realLetter.transform.parent = currentPoint.transform;
        realLetter.transform.position = currentPoint.transform.position;


        for (int i = 0; i < 3; i++)
        {
            //HashSet<int> alreadyChosen = new HashSet<int>();
            randomIndex = Random.Range(0, freeSpaces.Count);
            randomNumber = freeSpaces[randomIndex];
            freeSpaces.RemoveAt(randomIndex);

            index = /*Random.Range(0, freeSpaces.Count)*/randomNumber;
            currentPoint = letterAnchors[index];
            GameObject fakeLetterFab = Instantiate(fakeLetter, transform.position, transform.rotation) as GameObject;
            fakeLetterFab.transform.parent = currentPoint.transform;
            fakeLetterFab.transform.position = currentPoint.transform.position;
        }
    }
}
