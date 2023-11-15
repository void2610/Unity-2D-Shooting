using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    private const float SPEED = 0.04f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
        }


        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * SPEED;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * SPEED;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * SPEED;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * SPEED;
        }
    }
}
