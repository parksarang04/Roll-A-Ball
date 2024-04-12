using System; // 기본 시스템 클래스
using System.Collections; // 기본 컬렉션 클래스 (사용 안 함)
using System.Collections.Generic; // 제네릭 컬렉션 클래스 (사용 안 함)
using System.Security.Cryptography.X509Certificates; // 보안 인증서 클래스 (사용 안 함)
using UnityEngine; // 유니티 엔진 기본 라이브러리

public class PlayerController : MonoBehaviour // MonoBehaviour 상속받는 클래스 선언
{
    // Movement3D 스크립트를 저장하는 변수
    private Movement3D movement3D;

    // Awake() 함수: MonoBehaviour의 기본 함수, 객체 생성 시 한 번만 호출 
    private void Awake()
    {
        // GetComponent<Movement3D>() 함수를 통해 게임오브젝트에서 Movement3D 스크립트 가져와 저장
        movement3D = GetComponent<Movement3D>();
    }

    // Update() 함수: MonoBehaviour의 기본 함수, 매 프레임마다 호출
    private void Update()
    {
        // 입력축 "Horizontal" 값을 x 변수에 저장 (-1 ~ 1)
        float x = Input.GetAxis("Horizontal");

        // 입력축 "Vertical" 값을 z 변수에 저장 (-1 ~ 1)
        float z = Input.GetAxis("Vertical");

        // x 또는 z축 이동 입력이 있는 경우 (대각선 이동 포함)
        if (x != 0 || z != 0)
        {
            // 이동 방향 벡터 생성 (x, 0, z)
            Vector3 moveDirection = new Vector3(x, 0, z);

            // Movement3D 스크립트의 MovoTo 함수를 호출하여 이동 실행
            movement3D.MovoTo(moveDirection);
        }
    }
}
