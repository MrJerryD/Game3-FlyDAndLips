using UnityEngine;

public class PlayerControllerTouch : MonoBehaviour
{
    private Vector3 targetPosition; // для пальца ли мышки

    public GameObject player;
    private float speed = 10f;

    private void Update()
    {
        if (StartGame.isStart) // если игра началась, обрабатываем код
        {
    #if UNITY_ANDROID
            if (Input.touchCount > 0) // проверяем тач
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    //Debug.Log("Touch " + targetPosition);
                }
            }
    #endif
    #if UNITY_EDITOR
            // проверяем ли реагирует на нажатие мышки
            if (Input.GetMouseButton(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //Debug.Log("Mouse " + targetPosition);
            }
#endif

            float step = speed * Time.deltaTime;
            if (targetPosition.y < -4f)
            {
                targetPosition.y = -4f;
            }
            else if (targetPosition.y > 4f)
            {
                targetPosition.y = 4f;
            }

            if (targetPosition.x < -7.80f)
            {
                targetPosition.x = -7.80f;
            }
            else if (targetPosition.x > 7.80f)
            {
                targetPosition.x = 7.80f;
            }
            player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(targetPosition.x, targetPosition.y, player.transform.position.z), step); // движение обьекта
        }

    }
}
