using UnityEngine;

public class AccelerationPlatform : MonoBehaviour
{
    [SerializeField]
    private float accelerationForce; // ���� ��
    [SerializeField]
    private Vector3 accelerationDirection; // ���� ����

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ���ӿ�����Ʈ�� �±װ� "Player" �̰� Rigidbody ������Ʈ�� �ִ� ���
        if (collision.collider.CompareTag("Player") && collision.rigidbody != null)
        {
            // �÷��̾��� Movement3D ������Ʈ�� ������ MovoTo �Լ� ȣ��
            Movement3D movement3D = collision.collider.GetComponent<Movement3D>();
            if (movement3D != null)
            {
                movement3D.MovoTo(accelerationDirection, accelerationForce);
            }
        }
    }
}
//�÷��̾ AccelerationPlatform ������Ʈ�� �浹�ϸ� accelerationDirection �������� accelerationForce ����ŭ ���ư���
//�ٵ� �ȳ��� ����?
