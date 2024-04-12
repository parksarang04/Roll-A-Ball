// **using UnityEngine:** 유니티 엔진 기본 라이브러리

using UnityEngine;

public class Movement3D : MonoBehaviour // MonoBehaviour 상속받는 클래스 선언
{
    // 이동 속도를 저장하는 변수 (SerializeField로 Inspector에서 설정 가능)
    [SerializeField]
    private float moveSpeed;

    // 3D 리지드바디를 저장하는 변수
    private Rigidbody rigidbody3D;

    // Awake() 함수: MonoBehaviour의 기본 함수, 객체 생성 시 한 번만 호출
    private void Awake()
    {
        // GetComponent<Rigidbody>() 함수를 통해 컴포넌트에서 Rigidbody 가져와 저장
        rigidbody3D = GetComponent<Rigidbody>();
    }

    // MovoTo() 함수: 공개 함수, 이동 방향과 힘을 받아 이동
    public void MovoTo(Vector3 direction, float force = 0)
    {
        // 이동 힘을 저장하는 변수
        Vector3 moveForce = Vector3.zero;

        // 힘 값이 0일 경우
        if (force == 0)
        {
            // y축 이동 제거
            direction.y = 0;
            // 이동 방향 정규화 후 속도 곱하여 moveForce에 저장
            moveForce = direction.normalized * moveSpeed;
        }
        else
        {
            // 힘 값을 moveForce에 저장
            moveForce = direction * force;
        }



        // moveForce 힘으로 오브젝트 이동
        rigidbody3D.AddForce(moveForce);
    }
}
