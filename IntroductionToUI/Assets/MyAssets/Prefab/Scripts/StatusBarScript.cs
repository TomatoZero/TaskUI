using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBarScript : MonoBehaviour
{
    private Slider slider; 
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, 100f, 0.15f);
    }
}
