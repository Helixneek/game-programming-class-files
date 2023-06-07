using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private Text timer;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void FixedUpdate()
    {
        SetText(gameManager.GetTime());
    }
    public void SetText(int time)
    {
        timer.text = time/60 + ":" + time%60;
    }
}
