using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Finance : MonoBehaviour
{
    public GameObject UVED;
    public TextMeshProUGUI moneyText;
    public GameObject button;
    public Animator anim;
    
    public void OnClick()
    {
        button.SetActive(false);
        anim.SetBool("toFabric", true);
    }

    public void OnClick2()
    {
        moneyText.text = "1600";
        UVED.SetActive(false);
    }
}
