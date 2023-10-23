using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    // move bg
    public float speed = 10f;

    private void Update()
    {
        if (StartGame.isStart) // обратились к другом скрипту и переменной static
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
