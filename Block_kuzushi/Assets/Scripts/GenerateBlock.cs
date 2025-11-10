using UnityEngine;

public class GenerateBlock : MonoBehaviour
{
    [Header("Block Settings")]
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private int width = 5;
    [SerializeField] private int height = 3;
    [SerializeField] private Vector2 generatePosition = new Vector2(-4f, 3f);
    [SerializeField] private Vector2 distanceBlock = new Vector2(1.6f, 0.8f);

    public int Width => width;
    public int Height => height;

    public void GenerateBlocks()
    {
        if (blockPrefab == null)
        {
            Debug.LogError("Block Prefab が設定されていません！");
            return;
        }

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector2 spawnPosition = new Vector2(
                    generatePosition.x + x * distanceBlock.x,
                    generatePosition.y - y * distanceBlock.y
                );

                Instantiate(blockPrefab, spawnPosition, Quaternion.identity, this.transform);
            }
        }
    }
}
