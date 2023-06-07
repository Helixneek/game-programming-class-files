using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Image image;
    private Enemy enemy;

    private void Awake()
    {
        image = GetComponentInChildren<Image>();
        enemy = GetComponentInParent<Enemy>();
    }

    // Update HP bar UI
    public void SetFillAmount(float amount)
    {
        image.fillAmount = amount;
    }

    public void OnEnable()
    {
        // Observe current HP
        enemy.OnDamageTaken += SetFillAmount;
    }

    public void OnDisable()
    {
        enemy.OnDamageTaken -= SetFillAmount;
    }
}
