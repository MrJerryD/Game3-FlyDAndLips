using System.Collections;
using UnityEngine;

public class DicksSmallCreate : MonoBehaviour
{
    public GameObject dickmall;
    private float waitTime = 1f;
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
            Instantiate(dickmall, new Vector2(17.5f, Random.Range(-4.4f, 4.4f)), Quaternion.identity);
            yield return new WaitForSeconds(waitTime); // чтобы не зависла игра, а dick появлялись каждую секунду
        }

        // Завершение корутины после остановки
        isSpawnDicks = false;
    }
}