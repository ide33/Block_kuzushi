using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * input * moveSpeed * Time.deltaTime);
    }
}
