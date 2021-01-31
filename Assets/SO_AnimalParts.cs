using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BodyPart", menuName = "BodyPart", order = 1)]


public class SO_AnimalParts : ScriptableObject

{
    public enum PartType {body, ears, extra, eyes, legs, tail}
    public enum PartIdentifier {regular, tentacle, webbed, spiky, hooves, stubby, fluffy, big, round, floppy, cyclops, gem}
    public string partName;
    public PartType partType;
    public PartIdentifier partID;
    public Sprite partSprite, typeSprite, idSprite;
}
