using UnityEngine;

public class RoleManager : MonoBehaviour
{
    public Logist logistCanvas;
    public GameObject slider;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            logistCanvas.ActivateRole();
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            slider.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Plus))
        {
            
        }
    }
}
