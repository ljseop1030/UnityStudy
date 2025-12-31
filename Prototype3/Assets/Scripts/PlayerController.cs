using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // Player 물리력 관련
    private bool isOnGround = true;

    public float jumpForce=10;
    public float gravityModifier=1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //두번째 생략시 ForceMode.Force
            //ForceMode: Force(F=ma) / Impulse(질랑고려. 순간적인 충격) / Acceleration(질량무시. 지속적인 a) / VelocityChange(질량무시 순간적인 속도변경)
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;       
    }
}
