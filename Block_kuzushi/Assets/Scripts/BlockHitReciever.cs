using UnityEngine;

public class BlockHitReciever : MonoBehaviour
{
    public void OnBallHit()
    {
        BlockController.Instance.OnHit(this.gameObject);
    }
}
