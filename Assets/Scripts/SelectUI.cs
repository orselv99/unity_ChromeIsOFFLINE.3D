using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectUI : MonoBehaviour
{
    public KeyCode keyCode = KeyCode.None;
    private Button button;

    private void Awake()
    {
        this.button = GetComponent<Button>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(this.keyCode) == true)
        {
            this.button.onClick.Invoke();
        }
    }
}
