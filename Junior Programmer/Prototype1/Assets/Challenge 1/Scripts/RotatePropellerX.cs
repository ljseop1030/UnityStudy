using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 4;
    private Vector3 offset = new Vector3(0,0,1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(offset * speed * Time.deltaTime); // * Time.deltaTime 꼭 곱해주는게 좋다
    }
}
