using System;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    //component references
    [SerializeField] private Image hpBar;

    private King king;

    private void Start()
    {
        king = FindObjectOfType<King>();
    }
    private void Update()
    {
        SetValue(king.GetHealth().GetPercentage());
    }
    public void SetValue(float value)
    {
        hpBar.fillAmount = value;
    }
}
