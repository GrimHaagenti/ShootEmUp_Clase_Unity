using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private bool playerClose = false;
    enemy_manager parent;
    public int Offset;
    // Start is called before the first frame update
    void Start()
    {
        parent = GetComponentInParent<enemy_manager>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Vector2 motion = new Vector2(0, 0);
        float delta = Time.fixedDeltaTime * 100;
        switch (parent.current_form)
        {
            case enemy_manager.formation.PIRAMID:
            motion.y = -20;
                break;  
            case enemy_manager.formation.WAVE:
              
                motion = new Vector2(Mathf.Cos(Time.time)* 20, -20);
                break;
        }
        
      
        
       
        rigidBody.velocity = motion * delta;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.gameObject.tag;

        if (colliderTag == "ball")
        { 
            Destroy(this.gameObject);
            GameManager.score += 100; 
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string colliderTag = collision.gameObject.tag;
        if (colliderTag == "onCamera")
        {
            playerClose = true;

        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        string colliderTag = collision.gameObject.tag;
        if (colliderTag == "onCamera")
        {
            playerClose = false;
         
        }

    }

}
