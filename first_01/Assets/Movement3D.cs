using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float   moveSpeed;
    private Rigidbody rigidbody3D;

    private void Awake()
    {
        rigidbody3D=GetComponent<Rigidbody>();
    }

    public void MovoTo(Vector3 direction,float force=0)
    {
        Vector3 moveForce = Vector3.zero;
        
        if ( force == 0)
        {
            direction.y = 0;
            moveForce = direction.normalized * moveSpeed;
        }
        else
        {
            moveForce = direction * force;
        }

        //y축으로 이동하지 않도록 direction.y = 0;
        direction.y = 0;
        //이동방향을 정규화한 후 normalized*moveSpeed 곱해 moveForce에 저장
        moveForce = direction.normalized*moveSpeed;

        //moveForce의 힘으로 오브젝트를 민다.
        rigidbody3D.AddForce(moveForce);
    }
}