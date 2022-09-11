using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpKeyPressed;
    private float HorizontalInput;
    private float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(HorizontalInput, 0, VerticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection*5*Time.deltaTime,Space.World);

        if(movementDirection != Vector3.zero){
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720*Time.deltaTime);

        }

    }

    /* void FixedUpdate()
    {
        
        GetComponent<Rigidbody>().velocity = new Vector3(HorizontalInput * 5, GetComponent<Rigidbody>().velocity.y, VerticalInput*5);
        GetComponent<Rigidbody>().rotation = new 

    } */
}
