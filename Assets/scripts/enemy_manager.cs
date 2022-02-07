using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_manager : MonoBehaviour
{
    private int childrenNum;
    enemyController[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
       enemies = this.GetComponentsInChildren<enemyController>();
       Debug.Log(enemies.Length);
        for (int x = 0; x < enemies.Length; x++)
        {
            enemies[x].gameObject.SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "onCamera")
        {
            for (int x = 0; x < enemies.Length; x++)
            {
                enemies[x].gameObject.SetActive(true);
                
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "onCamera")
        {
            for (int x = 0; x < enemies.Length; x++)
            {
                enemies[x].gameObject.SetActive(false);

            }
        }
    }
}

