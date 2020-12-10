using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;

    private static int damage;

    public Bullet bullet;

    private void Start()
    {
        damage = bullet.bulletDamage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet") 
        {
            Damage();
        }
     }

    void Damage() 
    {
        health -= damage;

        if (health <= damage) 
        {
            Die();
        }

    }

    void Die() 
    {
        Destroy(gameObject);
    }

}
