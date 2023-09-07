using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float turnSpeed = 10.0f;
    private float speed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput*speed);
        // transform.Translate(Vector3.right * Time.deltaTime * horizontalInput*turnSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);

    }
}
