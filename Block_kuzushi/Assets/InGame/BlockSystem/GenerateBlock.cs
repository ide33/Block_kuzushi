using UnityEngine;

public class GenerateBlock : MonoBehaviour
{
    [Header("Block Settings")]
    [SerializeField] private GameObject blockPrefab;

    [Header("Generate Range")]
    [SerializeField] private Vector2 generatePosition = new Vector2(-4f, 3f);
    [SerializeField] private Vector2 rangeSize = new Vector2(8f, 4f);

    [Header("Block Count")]
    [SerializeField] private int width = 5;
    [SerializeField] private int height = 3;

    public int Width => width;
    public int Height => height;

    public void GenerateBlocks()
    {
        int createCount = 0;

        if (blockPrefab == null)
        {
            Debug.LogError("Block Prefab が設定されていません！");
            return;
        }

        float stepX = rangeSize.x / width;
        float stepY = rangeSize.y / height;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector2 spawnPosition = new Vector2(
                    generatePosition.x + (x + 0.5f) * stepX,
                    generatePosition.y - (y + 0.5f) * stepY
                );

                Instantiate(blockPrefab, spawnPosition, Quaternion.identity, this.transform);
                createCount++;
            }
        }

        BlockController.Instance.SetTotalBlock(createCount);
    }
}
