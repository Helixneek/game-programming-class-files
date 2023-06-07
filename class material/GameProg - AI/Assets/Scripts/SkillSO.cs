using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Skill", menuName = "Scriptable Objects/Skill")]
public class SkillSO : ScriptableObject
{
    public string skillName;
    public string skillDescription;
    public GameObject skillEffect;
    public Image skillIcon;
    public int skillLevel;
    public SkillDamageCost[] skillDamageCost;
}
