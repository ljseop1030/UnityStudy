using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // 5.0f <- f는 double을 float로 형번환

    // public/private 하려면 클래스 변수. method 안에 들어가면 무조건 private.
    // Inspector에 나오게 하려면 무조건 클래스 변수로.

    public float turnSpeed; // 미지정 시 기본값 0
    

    public float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // 프로젝트 실행되자마자 시작됨. 오브젝트 호출 안돼도. 1번만(초기 설정)
    void Start()
    {

    }

    // Update is called once per frame
    // 매 프레임마다 실행. 움직임, 입력체크 등에 사용.
    void Update() // 매 초 50~60번
    {
        // Move vehicle foward

        /*
        transform.Translate(0,0,1);

        // transform = 이 GameObject의 Transform 컴포넌트: 위치, 회전, 크기 정보 가지고 있음. 자동으로 접근 가능 (MonoBehaviour 덕분)
        // Translate = 이동시키는 함수
        */

        /*
        transform.Translate(Vector3.forward);

        // forward = 말 그대로 앞으로 가기(+1) -> 사실상 (0,0,1)이랑 같다!
        // vector3 : 3차원
        */

        /*
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

        // 모든 PC: 초당 20 이동 으로 통일 (원래는 사양마다 다름)
        // Time.deltaTime : 프레임 보정
        // 20 실제 속도

        // * 는 실제로 곱한다는 의미랑 비슷하게 사용되는거임!
        // Vector3.forward = (0, 0, 1), (0, 0, 1) * 0.016 = (0, 0, 0.016)  ← Time.deltaTime, (0, 0, 0.016) * 20 = (0, 0, 0.32)  ← 최종 이동 거리
        */

        horizontalInput = Input.GetAxis("Horizontal");
        // getAxis : WASD / 방향키
        // 계속 입력받아야 하니까 start 아니고 update에!
        // project settings -> input manager

        transform.Translate(Vector3.forward * Time.deltaTime * speed); // 하드코딩 넘버 지양
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // 초당 오른쪽으로 감. 오른쪽으로 가는 정도를 조정해서 좌우 방향조절.. 대박
        // horizontalInput: 바의 값을 받아서 사용
    }
}
