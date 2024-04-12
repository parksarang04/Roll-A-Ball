using UnityEngine;

public class AccelerationPlatform : MonoBehaviour
{
    [SerializeField]
    private float accelerationForce; // 가속 힘
    [SerializeField]
    private Vector3 accelerationDirection; // 가속 방향

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 게임오브젝트의 태그가 "Player" 이고 Rigidbody 컴포넌트가 있는 경우
        if (collision.collider.CompareTag("Player") && collision.rigidbody != null)
        {
            // 플레이어의 Movement3D 컴포넌트를 가져와 MovoTo 함수 호출
            Movement3D movement3D = collision.collider.GetComponent<Movement3D>();
            if (movement3D != null)
            {
                movement3D.MovoTo(accelerationDirection, accelerationForce);
            }
        }
    }
}
//플레이어가 AccelerationPlatform 오브젝트와 충돌하면 accelerationDirection 방향으로 accelerationForce 힘만큼 날아간다
//근데 안날라감 뭐노?
