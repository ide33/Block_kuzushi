using UnityEngine;

public class InputKeyPlayer : MonoBehaviour, IPlayerMove
{
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * input * moveSpeed * Time.deltaTime);
    }
}
