using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject hiteffect;

    public int bulletDamage = 10;

    private Shake shake;

    public Collider2D colliderComp;
    public Collider2D playerCollider;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Collider2D bulletCollider = gameObject.GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(playerCollider, bulletCollider);
            Debug.Log("Ignored!");
        }
    
        colliderComp.enabled = true;
        shake.CamShake();
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);        
    }


}
