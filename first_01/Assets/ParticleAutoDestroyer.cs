using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAutoDestroyer : MonoBehaviour
{
    private ParticleAutoDestroyer particle;
    private bool isPlaying;

    private void Awake()
    {
        particle = GetComponent<ParticleAutoDestroyer>();
    }

    private void Update()
    {
        //��ƼŬ�� ������� �ƴϸ� ����
        if (particle.isPlaying == false)
        {
            Destroy(gameObject);
        }
    }

}
