using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffectPrefab;
    private float rotateSpeed = 100.0f;

    private void Update()
    {
        //코인 오브젝트 회전
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject clone = Instantiate(coinEffectPrefab);
        clone.transform.position = transform.position;

        Destroy(gameObject);
    }
}
