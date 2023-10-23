using UnityEngine;

public class DicksSmallMove : MonoBehaviour
{
    // move dicks
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart) // обратились к другом скрипту и переменной static
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x < -10.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}
