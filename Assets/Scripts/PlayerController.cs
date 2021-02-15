using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // rate of forward/backward movement
   private float speed = 15.0f;
    // rate of turning's speed
   private float turnSpeed = 30.0f;

   private float horizontalInput;
   private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);
    // Code that allows forward and backward movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    // Code that allows turning
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
