using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator ;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent <Animator> ();
       
    }

    // Update is called once per frame
    void Update()
    {
        bool isJumping = animator.GetBool("isJumping");
        bool hyppy = Input.GetKey("space");

        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
       // bool forwardPressed = Input.GetKey("a");
        
        bool runPressed = Input.GetKey("left shift");
        bool isrunning = animator.GetBool("isRunning");


        if (!isJumping && hyppy)

        {
            animator.SetBool("isJumping", true);
        }
        if (isJumping && !hyppy)

        {
            animator.SetBool("isJumping", false);
        }



        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isrunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        if (isrunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
