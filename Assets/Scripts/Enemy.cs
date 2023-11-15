using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0.1f; // 移動速度
    private float changeDirectionInterval = 2f; // 方向を変える間隔

    private float timer;
    private int direction; // -1: 左, 1: 右

    void SetRandomDirection()
    {
        // ランダムな方向を設定
        direction = Random.Range(0, 2) * 2 - 1; // -1または1
    }

    void MoveEnemy()
    {
        // 現在の位置からランダムな方向に速度を加える
        Vector2 movement = new Vector2(direction * speed, 0);
        this.transform.position += (Vector3)movement;
    }
    void Start()
    {
        //changeRandomDirectionIntervalをランダムな値に設定
        changeDirectionInterval = Random.Range(0.1f, 1.5f);
        timer = changeDirectionInterval;
        SetRandomDirection();
    }

    // Update is called once per frame

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SetRandomDirection();
            timer = changeDirectionInterval;
        }
    }

    void FixedUpdate()
    {
        MoveEnemy();
    }
}
