using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement2D : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float horizontalMove = 0f;
    public float runSpeed = 40f;

    public bool jump = false;
    public bool crouch = false;

    void Update() {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("Jumping", true);

        }

        if (Input.GetButtonDown("Crouch")) {

            crouch = true;
            animator.SetBool("Crouching", true);

        }
        
        else if(Input.GetButtonUp("Crouch")) {

            crouch = false;
            animator.SetBool("Crouching", false);

        }

    }

    public void OnLanding() {

        animator.SetBool("Jumping", false);

    }

    public void OnCrouching (bool Crouching) {

        animator.SetBool("Crouching", Crouching);

    }

    void FixedUpdate() {

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
