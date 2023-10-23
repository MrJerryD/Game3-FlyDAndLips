using UnityEngine.UI;
using UnityEngine;

public class DickFind : MonoBehaviour
{
    public Text text;
    private float dicks = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dick")
        {
            dicks++;
            UpdateCountText();
            Destroy(collision.gameObject);
        }
    }

    void UpdateCountText()
    {
        text.text = "Score: " + dicks;
    }
}
