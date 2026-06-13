using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private AudioSource DeathSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Enemy"))
        {
            Rigidbody2D playerRb = GetComponent<Rigidbody2D>();
            if (playerRb != null && playerRb.velocity.y < 0)
            {
                DeathSoundEffect?.Play();
                Destroy(collision.gameObject);
            }
        }
    }

}
