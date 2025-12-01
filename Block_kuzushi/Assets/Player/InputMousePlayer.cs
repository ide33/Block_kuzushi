using UnityEngine;

public class InputMousePlayer : MonoBehaviour, IPlayerMove
{
    Vector3 mousePos, worldPos;

    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        transform.position = new Vector3(worldPos.x, transform.position.y, transform.position.z);
    }
}
