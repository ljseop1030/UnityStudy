using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    public Vector3 offset = new Vector3(0,5,-8); // 벡터는 new Vector3로 만들어줘야함. 클래스인가봄.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // Update가 발생한 이후에 실행. 차가 움직인 직후 따라감. 동시에 움직이느라 지글거리는 효과 없앨 수 있음.
    {
        transform.position = player.transform.position + offset;        
        // player의 위치에 (0,5,-8) 더해서 카메라 위치 지정. 같은 3차원 vector로 만들어줘야 함.
    }
}
