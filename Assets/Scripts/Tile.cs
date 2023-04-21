using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Transform[] characters = null;
    private TileManager tileManager = null;
    private int trexType = 0;

    private void Awake()
    {
        this.tileManager = GetComponentInParent<TileManager>();
        SetRandomTRex();
    }

    private void LateUpdate()
    {
        
        if (this.transform.position.z == 2f)
        {
            this.transform.Translate(0, 0, this.tileManager.tileCount * this.tileManager.tileSize * -1f);
            SetRandomTRex();
        }
    }

    private void SetRandomTRex()
    {
        // ·£´ýÀ¸·Î »ö»óº¯°æ (ÃÑ 3°¡Áö »ö R:0, G:1, B:2)
        this.trexType = Random.Range(0, this.characters.Length);
        for (var i = 0; i < this.characters.Length; i++)
        {
            this.characters[i].gameObject.SetActive(i == trexType);
        }
    }

    public bool IsMatchedTRex(int trexType)
    {
        var result = (this.trexType == trexType);

        if (result == true)
        {
            // ¶³±Å
        }

        return result;
    }
}
