using UnityEngine;

public class BlockHitReciever : MonoBehaviour
{
    // public void OnHit()
    // {
    //     Debug.Log("Block Hit!");
    // }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     collision.gameObject.SendMessage("OnHit", SendMessageOptions.DontRequireReceiver);
    // }

    // private BlockController blockController;

    // private void Awake()
    // {
    //     blockController = GetComponent<BlockController>();
    // }

    public void OnBallHit()
    {
        BlockController.Instance.OnHit(this.gameObject);
    }
}
