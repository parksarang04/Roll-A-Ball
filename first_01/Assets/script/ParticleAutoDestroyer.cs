using UnityEngine;

public class ParticleAutoDestroyer : MonoBehaviour
{
    // 삭제: private ParticleAutoDestroyer particle; (불필요)
    private ParticleSystem particleSystem; // ParticleSystem 컴포넌트 참조
    private bool isPlaying; // 파티클 시스템 재생 여부 플래그

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>(); // ParticleSystem 컴포넌트 가져오기
        isPlaying = particleSystem.isPlaying; // 초기 재생 상태 확인
    }

    private void Update()
    {
        isPlaying = particleSystem.isPlaying; // 재생 상태 업데이트

        // 파티클 시스템 재생 중이 아닐 경우 게임오브젝트 삭제
        if (!isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
