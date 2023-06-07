using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudioController : MonoBehaviour
{
    private Enemy enemy;
    private AudioSource audioSource;

    public AudioClip damageTakenAudioClip;
    public AudioClip footstepAudioClip;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        audioSource = GetComponent<AudioSource>();

        // Make one of these any time a different situation needs a sound
        enemy.OnDamageTaken += PlayAudioDamageTaken;
    }

    private void PlayAudioDamageTaken(float healthPercentage)
    {
        audioSource.clip = damageTakenAudioClip;
        audioSource.Play();
    }
}
