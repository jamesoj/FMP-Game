using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            Anim.SetBool("IsRunning", true);

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Anim.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W))
        {

            Anim.SetBool("IsWalking", true);

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)|| Input.GetKeyUp(KeyCode.W))
        {
            Anim.SetBool("IsWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.S))
        {
            Anim.SetBool("IsWalkingBack", true);

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.S))
        {
            Anim.SetBool("IsWalkingBack", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {

            Anim.SetBool("IsWalkingLeft", true);

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            Anim.SetBool("IsWalkingLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {

            Anim.SetBool("IsWalkingRight", true);

        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            Anim.SetBool("IsWalkingRight", false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Anim.SetBool("IsAttacking", true);

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Anim.SetBool("IsAttacking", false);
        }
    }
}
