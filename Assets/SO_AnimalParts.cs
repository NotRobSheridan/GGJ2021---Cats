using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AnimalPart", order = 1)]


public class SO_AnimalParts : ScriptableObject

{
    public enum PartType {body, ears, extra, eyes, legs, tail}
    public enum PartIdentifier {spiky, spider, fluffy, dragon}

    public string partName;
    public PartType partType;
    public PartIdentifier partID;
    public Sprite partSprite;
}
