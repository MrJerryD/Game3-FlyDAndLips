using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
