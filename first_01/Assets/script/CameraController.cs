using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target; // 카메라가 추종할 대상
    [SerializeField]
    private float minDistance = 3; // 최소 거리
    [SerializeField]
    private float maxDistance = 30; // 최대 거리
    [SerializeField]
    private float zoomSpeed = 500; // 카메라 확대/축소 속도
    [SerializeField]
    private float rotateSpeed = 500; // 카메라 회전 속도

    private float distance; // 카메라와 대상 간 거리

    private void Awake()
    {
        // 초기 거리 설정
        distance = Vector3.Distance(transform.position, target.position);
    }

    private void Update()
    {
        if (target == null) return;

        // 마우스 오른쪽 버튼 클릭 시 카메라 회전
        if (Input.GetMouseButton(1))
        {
            // 마우스 움직임에 따라 카메라 회전
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
            transform.RotateAround(target.position, Vector3.right, -Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime);
        }

        // 마우스 휠 스크롤로 카메라 확대/축소
        distance -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
    }

    private void LateUpdate()
    {
        if (target == null) return;

        // 카메라 위치 설정
        transform.position = target.position - transform.forward * distance;
    }
}
