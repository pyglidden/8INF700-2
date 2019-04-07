using UnityEngine;
using System;
using System.Collections;


public class wincolor : MonoBehaviour
{
    public float time;
    int cycle = 0;
    bool isCycling;
    Material myMaterial;

    private void Awake()
    {
        isCycling = false;
        myMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (!isCycling)
        {
            if (cycle == 0)
                StartCoroutine(CycleMaterial(Color.green, Color.yellow, time, myMaterial));
            if (cycle == 1)
                StartCoroutine(CycleMaterial(Color.yellow, Color.red, time, myMaterial));
            if (cycle == 2)
                StartCoroutine(CycleMaterial(Color.red, Color.blue, time, myMaterial));
            if (cycle == 3)
                StartCoroutine(CycleMaterial(Color.blue, Color.green, time, myMaterial));
        }
    }

    IEnumerator CycleMaterial(Color startColor, Color endColor, float cycleTime, Material mat)
    {
        isCycling = true;
        float currentTime = 0;
        while (currentTime < cycleTime)
        {
            currentTime += Time.deltaTime;
            float t = currentTime / cycleTime;
            Color currentColor = Color.Lerp(startColor, endColor, t);
            mat.color = currentColor;
            yield return null;
        }
        isCycling = false;
        cycle++;
        if (cycle >= 4)
            cycle = 0;

    }

}