using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Vector2 gravity;
    [SerializeField] private float time;

    private void Awake()
    {
        Physics2D.gravity = gravity;
    }

    private void Update()
    {
        time -= Time.deltaTime;
    }

    internal int GetTime()
    {
        return (int)time;
    }
}
