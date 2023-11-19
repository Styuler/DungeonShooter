using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProjectile : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name != "Player")
        {
            if (col.GetComponent<EnemyRecieveDamage>() != null)
            {
                col.GetComponent<EnemyRecieveDamage>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
