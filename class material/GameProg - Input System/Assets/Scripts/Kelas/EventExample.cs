using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventExample : MonoBehaviour
{
    public Action action;
    public UnityAction unityAction;
    public UnityEvent unityEvent;

    private void Start()
    {
        unityEvent.Invoke();
    }

    private void OnEnable()
    {
        // Add to unity action and unity event
        unityAction += Speak;
        unityEvent.AddListener(Speak);
    }

    private void OnDisable()
    {
        // Remove from unity event and action
        unityEvent.RemoveListener(Speak);
        unityAction -= Speak;
    }

    public void Speak()
    {
        Debug.Log($"Character is speaking");
    }
}
