using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboUI : MonoBehaviour
{
    private Text text = null;

    private void Awake()
    {
        this.text = GetComponent<Text>();
    }

    private void LateUpdate()
    {
        this.text.text = string.Format("{0} Combo!", GameManager.combo);
    }
}
