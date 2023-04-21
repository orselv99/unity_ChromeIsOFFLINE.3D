using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUI : MonoBehaviour
{
    private Slider slider = null;
    public Image fill = null;
    public Color high = Color.black;
    public Color mid = Color.black;
    public Color low = Color.black;

    private void Awake()
    {
        this.slider = GetComponent<Slider>();
    }

    private void LateUpdate()
    {
        var value = (GameManager.maxGameTime - GameManager.playGameTime) / GameManager.maxGameTime;
        this.slider.value = value;
        if (value > 0.7)
        {
            this.fill.color = this.high;
        }
        else if (value > 0.4)
        {
            this.fill.color = this.mid;
        }
        else
        {
            this.fill.color = this.low;
        }

    }
}
