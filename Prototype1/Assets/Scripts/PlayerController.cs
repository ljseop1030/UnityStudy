using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    

    public float horizontalInput = 0;
    public float fowardInput = 1;

    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        fowardInput = Input.GetAxis("Vertical"); 

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
