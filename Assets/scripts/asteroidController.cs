using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidController : MonoBehaviour
{
    public float rotationSpeed = 300;

    public float velocityX;

    public float velocityY;
    public GameObject childAsteroid;
    Rigidbody2D rigidBody;
    public Vector2 vel;
    Vector3 rot;
     

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-40, 40 );
        vel.x = Random.Range(-20, 20 );
        vel.y = Random.Range(-20,20);
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
            Destroy(collision.gameObject);
            GameObject newAsteroid1 = Instantiate(childAsteroid, rigidBody.transform.position, rigidBody.transform.rotation);
            GameObject newAsteroid2 = Instantiate(childAsteroid, rigidBody.transform.position, rigidBody.transform.rotation);

            newAsteroid1.GetComponent<Rigidbody2D>().velocity = vel*10 ;
            newAsteroid2.GetComponent<Rigidbody2D>().velocity = -vel*10 ;

           
           
         

            Destroy(this.gameObject);
            

        }
    }

}
