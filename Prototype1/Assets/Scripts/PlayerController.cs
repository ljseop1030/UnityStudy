using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables

    private float speed = 5.0f;
    private float turnSpeed = 5.0f;
    
    private float horizontalInput = 0;
    private float fowardInput = 1;

    void Start()
    {

    }


    void Update()
    {
        // Get input
        horizontalInput = Input.GetAxis("Horizontal"); 
        fowardInput = Input.GetAxis("Vertical"); 

        // Move vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
