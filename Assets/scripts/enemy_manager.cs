using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_manager : MonoBehaviour
{
    private int childrenNum;
    enemyController[] enemies;


    public enum formation {PIRAMID, WAVE}

    public formation current_form = formation.PIRAMID;
    // Start is called before the first frame update
    void Start()
    {
        
       enemies = this.GetComponentsInChildren<enemyController>();
       Debug.Log(enemies.Length);
       
        if (enemies.Length == 5)
        {
            current_form = formation.PIRAMID;
        }
        else { current_form = formation.WAVE; }
        for (int x = 0; x < enemies.Length; x++)
        {
            enemies[x].gameObject.SetActive(false);

        }
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
                if (enemies[x] != null)
                {
                    enemies[x].gameObject.SetActive(false);
                }
            }
        }
    }
}

