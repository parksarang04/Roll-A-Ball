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
        //파티클이 재생중이 아니면 삭제
        if (particle.isPlaying == false)
        {
            Destroy(gameObject);
        }
    }

}
