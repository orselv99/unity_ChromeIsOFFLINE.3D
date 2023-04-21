using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitUI : MonoBehaviour
{
    private Text text = null;

    private void Awake()
    {
        this.text = GetComponent<Text>();
    }

    private void LateUpdate()
    {
        this.text.text = GameManager.hit.ToString();
    }
}
