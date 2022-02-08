using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static float baseSpeed { get; set; }

    public float interval = 2f;
    public float timer = 0.0f;

    public static int score = 0;
    public static bool on_boss;
    public static bool on_position;

    // Start is called before the first frame update
    void Awake()
    {
        on_position = false;
        on_boss = false;
        if (Instance == null)
        {
          
            Instance = this;
            DontDestroyOnLoad(this);  
          

        }
        else { Destroy(this.gameObject); }

        baseSpeed =0;
    }

    // Update is called once per frame
    void Update()
    {
        if (on_boss != true)
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                float delta = Time.fixedDeltaTime * 1000;
                GameManager.baseSpeed = Mathf.Lerp(GameManager.baseSpeed, 6.0f, 0.01f);
            }
        }
    }


    
}
