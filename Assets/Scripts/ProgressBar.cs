using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ProgressBar : MonoBehaviour
{
    public static event Action Completed;
    Image progressImage;
    [SerializeField] float timeToComplete;
    private static float progressValue = 0f;
    Animator anim;
    void Start()
    {       
        progressImage = GetComponent<Image>();
        ClickArea.ClickHappend += OnProgressAdded;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        progressValue += Time.deltaTime * GameManager.ProgressMultiplier;
        progressImage.fillAmount = progressValue / timeToComplete;

        if (progressValue > timeToComplete) {
            progressValue = 0f;
            Completed?.Invoke();
        }
    }

    void OnProgressAdded() {
        progressValue += GameManager.ProgressMultiplier;
        anim.Play("Pop"); 
    }
}
