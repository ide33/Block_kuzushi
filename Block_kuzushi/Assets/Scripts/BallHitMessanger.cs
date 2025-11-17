using UnityEngine;

public class BallHitMessanger : MonoBehaviour
{
    [SerializeField] private float startSpeed = 8f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.linearVelocity = new Vector2(1f, 1f).normalized * startSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BlockController block = collision.gameObject.GetComponent<BlockController>();
        if (block != null)
        {
            block.OnHit();
        }
    }
}
