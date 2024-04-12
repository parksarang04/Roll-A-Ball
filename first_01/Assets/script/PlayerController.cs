using System; // �⺻ �ý��� Ŭ����
using System.Collections; // �⺻ �÷��� Ŭ���� (��� �� ��)
using System.Collections.Generic; // ���׸� �÷��� Ŭ���� (��� �� ��)
using System.Security.Cryptography.X509Certificates; // ���� ������ Ŭ���� (��� �� ��)
using UnityEngine; // ����Ƽ ���� �⺻ ���̺귯��

public class PlayerController : MonoBehaviour // MonoBehaviour ��ӹ޴� Ŭ���� ����
{
    // Movement3D ��ũ��Ʈ�� �����ϴ� ����
    private Movement3D movement3D;

    // Awake() �Լ�: MonoBehaviour�� �⺻ �Լ�, ��ü ���� �� �� ���� ȣ�� 
    private void Awake()
    {
        // GetComponent<Movement3D>() �Լ��� ���� ���ӿ�����Ʈ���� Movement3D ��ũ��Ʈ ������ ����
        movement3D = GetComponent<Movement3D>();
    }

    // Update() �Լ�: MonoBehaviour�� �⺻ �Լ�, �� �����Ӹ��� ȣ��
    private void Update()
    {
        // �Է��� "Horizontal" ���� x ������ ���� (-1 ~ 1)
        float x = Input.GetAxis("Horizontal");

        // �Է��� "Vertical" ���� z ������ ���� (-1 ~ 1)
        float z = Input.GetAxis("Vertical");

        // x �Ǵ� z�� �̵� �Է��� �ִ� ��� (�밢�� �̵� ����)
        if (x != 0 || z != 0)
        {
            // �̵� ���� ���� ���� (x, 0, z)
            Vector3 moveDirection = new Vector3(x, 0, z);

            // Movement3D ��ũ��Ʈ�� MovoTo �Լ��� ȣ���Ͽ� �̵� ����
            movement3D.MovoTo(moveDirection);
        }
    }
}
