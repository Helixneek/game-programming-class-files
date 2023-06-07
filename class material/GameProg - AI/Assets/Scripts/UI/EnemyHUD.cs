using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHUD : MonoBehaviour
{
    [SerializeField] private Image hpBar;

    private Enemy pig;

    private void Awake()
    {
        pig = GetComponentInParent<Enemy>();
    }
    private void FixedUpdate()
    {
        SetValue(pig.GetHealth().GetPercentage());
    }
    public void SetValue(float value)
    {
        hpBar.fillAmount = value;
    }
}
