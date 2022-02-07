using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float baseSpeed = 17.0f;
    


    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        

        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.gameObject.tag;
        
        if(colliderTag != "Ship")
        {
            
            
            Destroy(gameObject);

        }


    }
   
    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000;
        rigidBody.velocity = (transform.up * (baseSpeed)*delta);
        
    }

}
