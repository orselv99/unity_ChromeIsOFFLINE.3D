using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    private Tile[] tiles = null;
    public int tileCount = 0;   // tile ���� ���
    public float tileSize = 0f; // tile ���� ���

    private int currentTile = 0;

    private void Awake()
    {
        this.tiles = GetComponentsInChildren<Tile>();
        this.tileCount = this.tiles.Length;

        // tiles �� -1f �� �ڷ� �о ��ġ��
        if (this.tileCount < 0)
        {
            Debug.Log("At least one tile needs");
            return;
        }

        this.tileSize = this.tiles[0].GetComponentInChildren<BoxCollider>().size.z;
        for (var i = 0; i < this.tileCount; i++)
        {
            this.tiles[i].transform.Translate(0, 0, i * tileSize * -1f);
        }
    }

    public void SelectTRex(int trexType)
    {
        if (this.tiles[currentTile].IsMatchedTRex(trexType) == true)
        {
            // SelectUI ���� ������ KeyCode ���� ���� ���� ��� ȣ���
            var next = this.transform.position.z + 2f;

/*            while (this.transform.position.z < next)
            {
                this.transform.Translate(0, 0, next * Time.deltaTime * 10f);
            }*/

            this.transform.position = Vector3.forward * next;

            // ���� ���� �տ� �ִ� Ÿ���� index ���
            currentTile = (currentTile + 1) % this.tiles.Length;

            GameManager.Success();
        }
        else
        {
            GameManager.Fail();
        }
    }
}
