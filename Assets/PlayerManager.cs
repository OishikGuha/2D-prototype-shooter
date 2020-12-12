using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Animator animate;

    public int health;

    // Start is called before the first frame update
    void Start()
    {

    }

    void PDamage(int damage, bool animation) 
    {
        health -= damage;
        animate.SetBool("Damaging", animation);

        if (health <= 0) 
        {
            Die();
        }
    }

    void Die() 
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy") 
        {
            PDamage(10, true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy") 
        {
            PDamage(10, false);
        }
    }

}
