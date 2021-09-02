using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    float horizontalMov;
    float verticalMov;
    Vector3 moveDir;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {

        myInput();
    }

    void myInput()
    {
        horizontalMov = Input.GetAxisRaw("Horizontal");
        verticalMov = Input.GetAxisRaw("Vertical");

        moveDir = transform.right * -horizontalMov + transform.forward * -verticalMov;
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer()
    {
        rb.AddForce(moveDir * speed, ForceMode.Acceleration);
    }

}
