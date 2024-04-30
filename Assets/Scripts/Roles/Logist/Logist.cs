using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Logist : MonoBehaviour
{
    public GameObject Items;
    public GameObject B1;
    public GameObject B2;
    public GameObject List;
    public Animator Animator;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public List<GameObject> Effects;

    public void ActivateRole()
    {
        Items.SetActive(true);
        B1.SetActive(true);
        B2.SetActive(true);
    }

    public void OpenList()
    {
        List.SetActive(true);
    }
    
    public void OnClick()
    {
        EffectState(true);
    }

    public IEnumerator Cor()
    {
        yield return new WaitForSeconds(5f);
        List.SetActive(false);
        Animator.enabled = true;
    }
    
    public void EffectState(bool state)
    {
        foreach (var effect in Effects)
        {
            effect.SetActive(state);
        }
    }
}
