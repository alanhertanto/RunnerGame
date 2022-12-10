using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStatus", menuName = "Scriptable/Create Character Status", order = 1)]
public class CharacterStatusScriptable : ScriptableObject
{
    public string Name;
    public float Strength;
    public float Endurance;
    public float Agility;
}
