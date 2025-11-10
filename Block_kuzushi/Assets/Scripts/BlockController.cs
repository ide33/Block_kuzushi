using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GenerateBlock generateBlock;

    private int totalBlocks;
    private int destroyedBlocks;

    void Start()
    {
        BlockGenerate();
    }

    public void BlockGenerate()
    {
        if (generateBlock != null)
        {
            generateBlock.GenerateBlocks();
            totalBlocks = generateBlock.Width * generateBlock.Height;
            destroyedBlocks = 0;
        }
        else
        {
            Debug.LogError("GenerateBlock コンポーネントが設定されていません！");
        }
    }

}
