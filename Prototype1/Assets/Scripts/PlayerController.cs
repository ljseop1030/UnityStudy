using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
        transform.Translate(0,0,1);
        // transform = 이 GameObject의 Transform 컴포넌트: 위치, 회전, 크기 정보 가지고 있음. 자동으로 접근 가능 (MonoBehaviour 덕분)
        // Translate = 이동시키는 함수
    }
}
