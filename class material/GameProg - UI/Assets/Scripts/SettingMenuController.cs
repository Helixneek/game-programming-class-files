using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenuController : MonoBehaviour, IMenu
{
    private Canvas canvas;

    private void Awake()
    {
       canvas = GetComponent<Canvas>();
    }

    //[ContextMenu("Hide Menu")]
    public void Hide()
    {
       canvas.enabled = false;
    }

    //[ContextMenu("Show Menu")]
    public void Show()
    {
       canvas.enabled = true;
    }
}
