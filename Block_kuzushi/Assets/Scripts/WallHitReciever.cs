using UnityEngine;

public class WallHitReciever : MonoBehaviour
{
    public void OnBallHit()
    {
        GameManager.Instance.GameOver();
    }
}
