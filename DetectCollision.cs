using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public Color deathColor;
    private SpriteRenderer sr;

    private AudioSource audioEnd;
    private AudioSource audioFind;

    public Text text;
    private float dicks = 0;

    public GameObject panelLose;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>(); // меняем цвет смайлу
        audioEnd = GetComponent<AudioSource>();
        audioFind = transform.Find("DickFind").GetComponent<AudioSource>(); // Измените на GetComponentInChildren, если второй AudioSource дочерний
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SmallDick"))
        {
            StartGame.isStart = false; // осталавливаем игру как столкнулись с красным dick
            //Destroy(collision.gameObject); // уничтожаем обьект
            sr.color = deathColor;
            audioEnd.Play();

            panelLose.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Dick"))
        {
            Destroy(collision.gameObject); // уничтожаем обьект
            if (!audioFind.isPlaying)
            {
                audioFind.Play();
            }
            if (collision.gameObject.tag == "Dick")
            {
                dicks++;
                UpdateCountText();
                Destroy(collision.gameObject);
            }
        }
    }
    void UpdateCountText()
    {
        text.text = "Score: " + dicks;
    }
}
