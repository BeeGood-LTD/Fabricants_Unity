using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBuild : MonoBehaviour
{
    public Logist logist;
    
    private void OnMouseDown()
    {
        logist.Text1.text = "Общий склад";
        logist.EffectState(false);
    }
}
