using System.Collections;
using UnityEngine;

public class DicksCreate : MonoBehaviour
{
    public GameObject dick;
    private float waitTime = 1.5f;
    private bool isSpawnDicks;

    private void Update()
    {
        if (StartGame.isStart && !isSpawnDicks) // првоеряем ли запущенная игра, если да, то создаем dicks
        {
            StartCoroutine(spawnDicks());
            isSpawnDicks = true;
        }
    }

    IEnumerator spawnDicks()
    {
        while (StartGame.isStart)
        {
            Instantiate(dick, new Vector2(12.5f, Random.Range(-4.4f, 4.4f)), Quaternion.identity);
            yield return new WaitForSeconds(waitTime); // чтобы не зависла игра, а dick появлялись каждую секунду
        }

        // Завершение корутины после остановки
        isSpawnDicks = false;
    }

}
