using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
   
    private Rigidbody2D rigidBody;
    public float  interval = 2f;
    public float  timer = 0.0f;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {

        
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {   
            float delta = Time.fixedDeltaTime * 1000;
            gm.baseSpeed = Mathf.Lerp(gm.baseSpeed, 6.0f, 0.01f);
            rigidBody.velocity = (transform.up * (gm.baseSpeed * delta));

        }

    }


    

}
