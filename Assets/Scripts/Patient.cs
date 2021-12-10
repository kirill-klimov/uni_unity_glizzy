using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    [SerializeField] List<Sprite> sickSprites;
    [SerializeField] List<Sprite> healthySprites;
    int spriteIndex;
    ParticleSystem particles;
    bool isHealthy = false;
    void Start()
    {
        spriteIndex = Random.Range(0, 4);
        GetComponentsInChildren<SpriteRenderer>()[1].sprite = sickSprites[spriteIndex];
        particles = GetComponentInChildren<ParticleSystem>();
        ClickArea.ClickHappend += OnClickHappend;
    }

    public void MakeHealthy() {
        GetComponentsInChildren<SpriteRenderer>()[1].sprite = healthySprites[spriteIndex];
        isHealthy = true;
    }

    void OnClickHappend() {
        if (!isHealthy) {
            particles.Play();
        }
    }
}
