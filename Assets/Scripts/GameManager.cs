using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    [Header("Player")]
    public static float score = 0f;
    public static int hit = 0;
    public static int combo = 0;
    private static readonly float maxComboTime = 3f;    // combo
    private static float currentComboTime = 0f;         // combo
    public bool isGameOver = false;
    public static float playGameTime = 0f;
    public static float maxGameTime = 100f;

    [Header("UI")]
    public GameObject infoUI = null;
    public GameObject selectUI = null;
    public GameObject gameoverUI = null;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        
        instance = this;
        instance.StartCoroutine(instance.CheckCombo());
    }

    public static void Success()
    {
        hit++;
        combo++;
        score += 1 + (combo * 0.1f);
        currentComboTime = 0;
    }

    public static void Fail()
    {
        combo = 0;
    }

    private IEnumerator CheckCombo()
    {
        while (isGameOver == false)
        {
            yield return null;
            
            currentComboTime += Time.deltaTime;
            if (currentComboTime > maxComboTime)
            {
                combo = 0;
            }
        }
    }

    private static void StartGame()
    {
        playGameTime += Time.deltaTime;
    }

    private void GameOver()
    {
        this.isGameOver = true;
        this.infoUI.SetActive(false);
        this.selectUI.SetActive(false);
        this.gameoverUI.SetActive(true);
    }
}
