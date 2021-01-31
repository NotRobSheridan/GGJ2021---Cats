using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectChoice : MonoBehaviour
{
    public GameObject gameManager;
    AnimalGenerator animalGenerator;

    void Start()
    {
        gameManager = GameObject.Find("Animal_Main");
        animalGenerator = gameManager.GetComponent<AnimalGenerator>();
    }

    void OnMouseDown()
    {
        animalGenerator.IncorrectCat();
    }
}

