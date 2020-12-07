using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed = 2;
    private Animator Anim;



    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

            Anim.SetBool("IsBlocking", true);

        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Anim.SetBool("IsBlocking", false);
        }

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

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        { 
            Speed = 4;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = 2;
        }
    }
}
