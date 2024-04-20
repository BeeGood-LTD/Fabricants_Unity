using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoleManager : MonoBehaviour
{
    public Logist logistCanvas;
    public Finance financeCanvas;
    public GameObject proizvodstvo;
    public GameObject prodovec;
    public GameObject genDir;
    public GameObject slider;
    
    public GameObject uved;
    public GameObject money;

    private float roundTime = 600;
    public List<TextMeshProUGUI> timers;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AllClose();
            prodovec.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AllClose();
            logistCanvas.gameObject.SetActive(true);
            logistCanvas.ActivateRole();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AllClose();
            financeCanvas.gameObject.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AllClose();
            proizvodstvo.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AllClose();
            genDir.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            slider.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            uved.SetActive(true);
            money.SetActive(true);
        }

        var timeText = Timer();
        foreach (var time in timers)
        {
            time.text = timeText;
        }
    }

    string Timer()
    {
        roundTime -= Time.deltaTime;
        
        int min = (int)(roundTime / 60);
        int sec = (int)roundTime - min * 60;

        string split = ":";
        
        if (sec < 10)
        {
            split = ":0";
        }

        string gameTime = min + split + sec;
        return gameTime;
    }
    
    public void AllClose()
    {
        logistCanvas.gameObject.SetActive(false);
        financeCanvas.gameObject.SetActive(false);
        proizvodstvo.SetActive(false);
        prodovec.SetActive(false);
        genDir.SetActive(false);
    }
}
