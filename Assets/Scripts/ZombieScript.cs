using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    Animator animator;
    float speed = 10.0f;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Stop", false);
        }

        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Stop", true);
            animator.SetBool("Walk", false);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.right);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);
            playerRB.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }
}
