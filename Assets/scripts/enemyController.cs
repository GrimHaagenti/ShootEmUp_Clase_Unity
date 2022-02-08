using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private bool playerClose = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 100;
        //Vector2 motion = new Vector2(0, 0);
        Vector2 motion = new Vector2(Mathf.Sin(Time.time) * 50, 0);
      
        motion.y = -20;
       
        rigidBody.velocity = motion * delta;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.gameObject.tag;

        if (colliderTag == "ball")
        { 
            Destroy(this.gameObject);

        }
        Debug.Log("AAAAAAAAAAAAA");
      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string colliderTag = collision.gameObject.tag;
        if( colliderTag == "onCamera")
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
