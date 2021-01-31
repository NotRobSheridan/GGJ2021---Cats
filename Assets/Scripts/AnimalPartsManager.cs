using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPartsManager : MonoBehaviour
{
    public SO_AnimalParts correctBody, correctEars, correctExtras, correctEyes, correctTail, correctLegs;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        CreateAnimal();
    }

    public void CreateAnimal()
    {
        GetBodies();
        GetEars();
        GetExtras();
        GetEyes();
        GetLegs();
        GetTails();
    }

    void GetBodies()
    {
        SO_AnimalParts[] Body = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Body");
        List<SO_AnimalParts> bodyList = new List<SO_AnimalParts>(Body);
        foreach (SO_AnimalParts body in bodyList)
        {
       //     Debug.Log(string.Format("{0} {1}", body.partID, body.partType));
        }
        correctBody = bodyList[Random.Range(0, bodyList.Count)];
    }

    void GetEars()
    {
        SO_AnimalParts[] Ear = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Ears");
        List<SO_AnimalParts> earList = new List<SO_AnimalParts>(Ear);
        foreach (SO_AnimalParts ear in earList)
        {
        //    Debug.Log(string.Format("{0} {1}", ear.partID, ear.partType));
        }
        correctEars = earList[Random.Range(0, earList.Count)];
    }

    void GetExtras()
    {
        SO_AnimalParts[] Extra = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Extra");
        List<SO_AnimalParts> extraList = new List<SO_AnimalParts>(Extra);
        foreach (SO_AnimalParts extra in extraList)
        {
           // Debug.Log(string.Format("{0} {1}", extra.partID, extra.partType));
        }
        correctExtras = extraList[Random.Range(0, extraList.Count)];

    }

    void GetEyes()
    {
        SO_AnimalParts[] Eyes = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Eyes");
        List<SO_AnimalParts> eyeList = new List<SO_AnimalParts>(Eyes);
        foreach (SO_AnimalParts eye in eyeList)
        {
            //Debug.Log(body.partID);
        }
        correctEyes = eyeList[Random.Range(0, eyeList.Count)];

    }

    void GetLegs()
    {
        SO_AnimalParts[] Legs = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Legs");
        List<SO_AnimalParts> legsList = new List<SO_AnimalParts>(Legs);
        foreach (SO_AnimalParts leg in legsList)
        {
            //Debug.Log(body.partID);
        }
        correctLegs = legsList[Random.Range(0, legsList.Count)];

    }

    void GetTails()
    {
        SO_AnimalParts[] Tail = Resources.LoadAll<SO_AnimalParts>("AnimalParts/Tails");
        List<SO_AnimalParts> tailList = new List<SO_AnimalParts>(Tail);
        foreach (SO_AnimalParts tail in tailList)
        {
            //Debug.Log(body.partID);
        }
                correctTail = tailList[Random.Range(0, tailList.Count)];

    }
}