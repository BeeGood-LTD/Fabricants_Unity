using UnityEngine;
using UnityEngine.UI;

public class CompleteWork : MonoBehaviour
{
    public Slider slider;
    public Animator anim;
    
    void Update()
    {
        slider.value -= Time.deltaTime;
        if (slider.value <= 0)
        {
            anim.SetBool("toShop", true);
            Destroy(gameObject);
        }
    }
}
