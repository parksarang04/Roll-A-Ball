using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffectPrefab; // 동전 이펙트 프리팹 (인스펙터 창에서 설정)
    private float rotateSpeed = 100.0f; // 회전 속도

    private void Update()
    {
        // 코인 오브젝트를 오른쪽 축 (Vector3.right) 기준으로 회전
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 콜리더가 플레이어 태그를 가지고 있을 경우
        if (other.CompareTag("Player"))
        {
            // 동전 이펙트 프리팹 생성
            GameObject clone = Instantiate(coinEffectPrefab);
            clone.transform.position = transform.position;

            // 현재 코인 게임오브젝트 삭제
            Destroy(gameObject);
        }
    }
}
