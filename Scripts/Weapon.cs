using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
            animator.SetBool("Shooting", true);
        }
        else {
            animator.SetBool("Shooting", false);
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
