using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioClip clickSound;
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        ClickArea.ClickHappend += OnClickHappend;
    }

    void OnClickHappend() {
        source.PlayOneShot(clickSound);
    }
}
