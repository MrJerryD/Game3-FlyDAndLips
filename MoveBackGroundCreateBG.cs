using UnityEngine;

public class MoveBackGroundCreateBG : MonoBehaviour
{
    public GameObject now_bg; // фон который сейчас на сцене
    public GameObject pref_bg; // префаб фона который будет подставлять след

    private GameObject new_bg; // закидываем префаб pref_bg

    private void Update()
    {
        if (StartGame.isStart) // другой скрипт || если now_bg уйдет налево больше чем на 0.20, то создается префаб, а ниже если префаб уходит также, то за ним след префаб
        {
            if (now_bg.transform.position.x <= 0.24f && new_bg == null)
            {
                createNewBg();
            }
            else if(new_bg != null && new_bg.transform.position.x <= 0.24f)
            {
                createNewBg();
            }
        }
    }

    void createNewBg()
    {
        if (now_bg.transform.position.x < -10f) // уничтожаем
        {
            Destroy(now_bg);
            // вметсо того который уничтожили, подставляем префаб
            now_bg = new_bg;
        }

        new_bg = Instantiate(pref_bg, new Vector2(18.39f, 0f), Quaternion.identity) as GameObject; // создаем новый фон на позиции по х 18.39, по y 0 
    }
}
