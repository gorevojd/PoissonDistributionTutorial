using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetation : MonoBehaviour
{
    public float minGrowTime = 0.8f;
    public float maxGrowTime = 1.2f;

    float growTime;
    float lifeTime;

    void Start()
    {
        transform.localScale = Vector3.zero;

        lifeTime = 0f;

        growTime = Random.Range(minGrowTime, maxGrowTime);
    }

    void Update()
    {
        float scale = lifeTime / growTime;
        scale = Mathf.Clamp01(scale);
        scale = Mathf.SmoothStep(0, 1, scale);

        transform.localScale = Vector3.one * scale;

        lifeTime += Time.deltaTime;
    }
}
