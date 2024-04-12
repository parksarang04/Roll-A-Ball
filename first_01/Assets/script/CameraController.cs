using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target; // ī�޶� ������ ���
    [SerializeField]
    private float minDistance = 3; // �ּ� �Ÿ�
    [SerializeField]
    private float maxDistance = 30; // �ִ� �Ÿ�
    [SerializeField]
    private float zoomSpeed = 500; // ī�޶� Ȯ��/��� �ӵ�
    [SerializeField]
    private float rotateSpeed = 500; // ī�޶� ȸ�� �ӵ�

    private float distance; // ī�޶�� ��� �� �Ÿ�

    private void Awake()
    {
        // �ʱ� �Ÿ� ����
        distance = Vector3.Distance(transform.position, target.position);
    }

    private void Update()
    {
        if (target == null) return;

        // ���콺 ������ ��ư Ŭ�� �� ī�޶� ȸ��
        if (Input.GetMouseButton(1))
        {
            // ���콺 �����ӿ� ���� ī�޶� ȸ��
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
            transform.RotateAround(target.position, Vector3.right, -Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime);
        }

        // ���콺 �� ��ũ�ѷ� ī�޶� Ȯ��/���
        distance -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
    }

    private void LateUpdate()
    {
        if (target == null) return;

        // ī�޶� ��ġ ����
        transform.position = target.position - transform.forward * distance;
    }
}
