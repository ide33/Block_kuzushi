using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void GameClear()
    {
        Debug.Log("ゲームクリア！");
        DestroyBall();
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー！");
        DestroyBall();
    }

    public void DestroyBall()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            Destroy(ball);
        }
    }
}
