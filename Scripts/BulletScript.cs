using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D Rb;
    public int Damage = 50;

    void Start() {
        Rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        EnemyScript enemy = hitInfo.GetComponent<EnemyScript>();
        if (enemy != null) {
            enemy.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }

}
