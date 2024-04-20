using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBuild : MonoBehaviour
{
    public Logist logist;
    
    private void OnMouseDown()
    {
        logist.Text2.text = "Фабрика";
        logist.EffectState(false);
        StartCoroutine(logist.Cor());
    }
}
