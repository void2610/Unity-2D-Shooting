using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 createdPosition;
    void Start()
    {
        createdPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.up * 0.1f;


        if (Vector3.Distance(createdPosition, this.transform.position) > 10)
        {
            //Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            GameManager.instance.AddScore(10);
        }
    }
}
