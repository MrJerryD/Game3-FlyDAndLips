using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logoText;
    public GameObject scoreText;
    public GameObject dickText;

    public static bool isStart; // обращаемся к переменной в классе MoveBackBG

    private void Update()
    {
        if (isStart && logoText != null)
        {
            logoText.transform.Translate(Vector2.up * 2.5f * Time.deltaTime);
        }
    }

    public void startGame()
    {
        if (isStart)
        {
            return;
        }

        isStart = true;
        logoText.GetComponent<Animator>().enabled = false;
        Destroy(logoText, 1.5f); // уничтожение обьекта через 2 секунды

        gameObject.GetComponent<Animation>().Play("PlayBtnAnimation");

        scoreText.SetActive(true);
        dickText.SetActive(true);
    }
}
