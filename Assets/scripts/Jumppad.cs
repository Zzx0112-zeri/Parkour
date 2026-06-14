using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    [Header("向上弹跳力度")]
    public float bouncePower = 8f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        // 判断碰到的是玩家（标签必须为 Player）
        if (col.collider.CompareTag("Player"))
        {
            Rigidbody2D playerRb = col.collider.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                // 清空垂直方向速度，避免下落速度抵消弹跳
                playerRb.velocity = new Vector2(playerRb.velocity.x, 0);
                // 施加瞬时向上弹力
                playerRb.AddForce(Vector2.up * bouncePower, ForceMode2D.Impulse);
            }
        }
    }
}
