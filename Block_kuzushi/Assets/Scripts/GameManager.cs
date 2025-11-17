using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int totalBlock;
    private int destroyedBlockCount;

    private void Awake()
    {
        Instance = this;
    }

    public void SetTotalBlock(int count)
    {
        totalBlock = count;
        // destroyedBlockCount = 0;
    }

    public void CountBlock()
    {
        destroyedBlockCount++;

        Debug.Log($"破壊数: {destroyedBlockCount} / {totalBlock}");

        if (AllBlockDestroyed())
        {
            GameClear();
        }
    }

    public bool AllBlockDestroyed()
    {
        return destroyedBlockCount >= totalBlock;
    }

    private void GameClear()
    {
        Debug.Log("ゲームクリア！");
    }

    private void GameOver()
    {
        Debug.Log("ゲームオーバー！");
    }
}
