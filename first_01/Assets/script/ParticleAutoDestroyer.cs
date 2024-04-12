using UnityEngine;

public class ParticleAutoDestroyer : MonoBehaviour
{
    // ����: private ParticleAutoDestroyer particle; (���ʿ�)
    private ParticleSystem particleSystem; // ParticleSystem ������Ʈ ����
    private bool isPlaying; // ��ƼŬ �ý��� ��� ���� �÷���

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>(); // ParticleSystem ������Ʈ ��������
        isPlaying = particleSystem.isPlaying; // �ʱ� ��� ���� Ȯ��
    }

    private void Update()
    {
        isPlaying = particleSystem.isPlaying; // ��� ���� ������Ʈ

        // ��ƼŬ �ý��� ��� ���� �ƴ� ��� ���ӿ�����Ʈ ����
        if (!isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
