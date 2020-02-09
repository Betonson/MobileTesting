using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    [SerializeField] private Material material;

    private float dissolveAmount = 0;

    public void Dissolve(bool isDissolving)
    {
        if (isDissolving)
        {
            dissolveAmount = Mathf.Clamp01(dissolveAmount + Time.deltaTime);
            material.SetFloat("_DissolveAmount", dissolveAmount);
        }else
        {
            dissolveAmount = Mathf.Clamp01(dissolveAmount - Time.deltaTime);
            material.SetFloat("_DissolveAmount", dissolveAmount);
        }
    }
}
