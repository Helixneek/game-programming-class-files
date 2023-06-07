using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [Header("General")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileLifetime = 5f;

    [Header("Player")]
    [SerializeField] float playerFiringRate = 1f;

    [HideInInspector] public bool isFiring;
    Coroutine firingCoroutine;
    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire() {
        
        if(isFiring && firingCoroutine == null) {

            firingCoroutine = StartCoroutine(FireContinously());
            Debug.Log("schut");

        } else if(!isFiring && firingCoroutine != null) {

            StopCoroutine(firingCoroutine);
            firingCoroutine = null;
        }
        
    }

    IEnumerator FireContinously() {

        while(true) {
            GameObject instance = Instantiate(projectilePrefab, 
                                            transform.position, 
                                            Quaternion.Euler(0, 0, 180));

            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if(rb != null) {
                
                rb.velocity = transform.up * projectileSpeed;

            } else if(rb != null) {

                rb.velocity = -transform.up * projectileSpeed;

            }

            //float bulletSpawnTime = Random.Range(enemyFiringRate - firingRateVariance, enemyFiringRate + firingRateVariance);

            Destroy(instance, projectileLifetime);

            yield return new WaitForSeconds(playerFiringRate);
            }
            
        }
    }
