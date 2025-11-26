using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private ScoreUI scoreUI;
    [SerializeField] private PassedTimeUI passedTimeUI;

    private int score;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        passedTimeUI.StartTime();
    }

    public void AddScore(int value)
    {
        score += value;
        scoreUI.UpdateScore(score);
    }

    public void GameClear()
    {
        passedTimeUI.StopTime();
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
