using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Animator An;
    private Rigidbody2D Rd;

    private void Start()
    {
        An = GetComponent<Animator>();
        Rd = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Die();
        }
    }

    private void Die()
    {
        An.SetTrigger("Death");
        Rd.bodyType = RigidbodyType2D.Static;
    }
}


