using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigAI : MonoBehaviour
{
    private Enemy enemy;
    private King king;
    //[SerializeField] float moveSpeed = 1f;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        king = FindObjectOfType<King>();
    }

    private void Start()
    {
        Patrol();
    }

    private void Update()
    {
        //if(isPlayerAround() == false)
        //{
        //    Patrol();
        //}
        //else
        //{
        //    Follow(player);

        //    if(isInRange(player))
        //    {
        //        enemy.Attack();
        //    }
        //}
    }

    //private void FollowPlayer()
    //{
    //    Vector3 direction = new Vector3(king.transform.position.x - transform.position.x, 0, king.transform.position.z - transform.position.z);
    //    enemy.transform.Translate(direction * moveSpeed);
    //}

    private void Patrol()
    {
        Vector3 leftBorder = transform.position - new Vector3(-2, 0, 0);
        Vector3 rightBorder = transform.position + new Vector3(2, 0, 0);

        enemy.SetDirection(1);

        Debug.Log("Patrolling");
    }
}
