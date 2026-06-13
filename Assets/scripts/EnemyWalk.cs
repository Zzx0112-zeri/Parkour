using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    private int moveDir = 1; // 1正向，-1反向

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        // 安全校验：至少2个路点
        if (waypoints == null || waypoints.Length < 2 || waypoints[currentWaypointIndex] == null)
            return;

        Vector2 currentPos = transform.position;
        Vector2 targetPos = waypoints[currentWaypointIndex].transform.position;

        // 到达当前路点
        if (Vector2.Distance(targetPos, currentPos) < 0.1f)
        {
            currentWaypointIndex += moveDir;

            // 走到终点/起点，反转移动方向 + 镜像翻转
            if (currentWaypointIndex >= waypoints.Length)
            {
                moveDir = -1;
                currentWaypointIndex = waypoints.Length - 2;
                FlipSprite();
            }
            else if (currentWaypointIndex < 0)
            {
                moveDir = 1;
                currentWaypointIndex = 1;
                FlipSprite();
            }
        }

        Vector2 nextTargetPos = waypoints[currentWaypointIndex].transform.position;
        transform.position = Vector2.MoveTowards(currentPos, nextTargetPos, Time.deltaTime * speed);
    }

    /// <summary>
    /// 水平镜像翻转精灵
    /// </summary>
    private void FlipSprite()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
