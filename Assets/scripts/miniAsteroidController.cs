using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniAsteroidController : MonoBehaviour
{
    public float rotationSpeed = 300;

    public float velocityX;

    public float velocityY;
    Rigidbody2D rigidBody;
    public Vector2 vel;
    Vector3 rot;
     

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-40, 40 );
       
        rot.z = rotationSpeed;

        rigidBody = GetComponent<Rigidbody2D>();
    }
 

    // Update is called once per frame
    void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000;

        rigidBody.velocity = (vel * delta)/1000;
        rigidBody.transform.Rotate(rot);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


       if(collision.gameObject.tag == "ball")
        {
            Destroy(this.gameObject);

        }
    }

}
