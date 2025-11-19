using UnityEngine;

public class BlockController : MonoBehaviour
{
    public static BlockController Instance;

    [SerializeField] private GenerateBlock generateBlock;

    private int totalBlock;
    private int destroyedBlockCount;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        generateBlock.GenerateBlocks();

        totalBlock = generateBlock.transform.childCount;
    }

    public void SetTotalBlock(int count)
    {
        totalBlock = count;
    }

    public void OnHit(GameObject block)
    {
        Debug.Log("Block Hit!");
        DestroyBlock(block);
    }

    public void DestroyBlock(GameObject block)
    {
        Destroy(block);
        CountBlock();
    }

    public void CountBlock()
    {
        destroyedBlockCount++;

        Debug.Log($"破壊数: {destroyedBlockCount} / {totalBlock}");

        if (destroyedBlockCount >= totalBlock)
        {
            GameManager.Instance.GameClear();
        }
    }
}
