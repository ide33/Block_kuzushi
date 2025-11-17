using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GenerateBlock generateBlock;

    void Start()
    {
        BlockGenerate();
    }

    public void BlockGenerate()
    {
        if (generateBlock != null)
        {
            generateBlock.GenerateBlocks();
        }
        else
        {
            Debug.LogError("GenerateBlock コンポーネントが設定されていません！");
        }
    }

    public void OnHit()
    {
        Debug.Log("Block Hit!");
    }

    public void DestroyBlock()
    {
        GameManager.Instance.CountBlock();
        Destroy(gameObject);
    }
}
