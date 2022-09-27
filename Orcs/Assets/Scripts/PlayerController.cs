using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    private float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }

        //horizontalInput = Input.GetAxis("Horizontal");

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    animator.SetTrigger("IsRunning");
        //    transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    animator.SetTrigger("IsRunning");
        //    transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        //    transform.Translate(-Vector3.forward * horizontalInput * speed * Time.deltaTime);
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    animator.SetTrigger("IsRunning");
        //    transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        //    transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        //}

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    animator.SetTrigger("IsRunning");
        //    transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        //    transform.Translate(-Vector3.right * horizontalInput * speed * Time.deltaTime);
        //}

        //transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
    }
}
