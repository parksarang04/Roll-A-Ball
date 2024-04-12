using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffectPrefab; // ���� ����Ʈ ������ (�ν����� â���� ����)
    private float rotateSpeed = 100.0f; // ȸ�� �ӵ�

    private void Update()
    {
        // ���� ������Ʈ�� ������ �� (Vector3.right) �������� ȸ��
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� �ݸ����� �÷��̾� �±׸� ������ ���� ���
        if (other.CompareTag("Player"))
        {
            // ���� ����Ʈ ������ ����
            GameObject clone = Instantiate(coinEffectPrefab);
            clone.transform.position = transform.position;

            // ���� ���� ���ӿ�����Ʈ ����
            Destroy(gameObject);
        }
    }
}
