using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_script : MonoBehaviour
{
    float time = 0.7f;
    Rigidbody2D rigidbody;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.on_boss == true && GameManager.on_position == false)
        {
            rigidbody.velocity = new Vector2(0, -150);

        }
        else if (GameManager.on_position == true) { 
            rigidbody.velocity = new Vector2(Mathf.Sin(Time.time) * 80, 0);
            time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                GameObject bullet = Instantiate(ball, transform.position, transform.rotation, this.transform);
                
                Destroy(bullet, 2.0f);
                time = 0.7f;
            }
        }



        
       
    }
}
