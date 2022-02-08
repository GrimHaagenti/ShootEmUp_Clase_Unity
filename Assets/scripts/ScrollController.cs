using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
   
    private Rigidbody2D rigidBody;
   
   

    // Start is called before the first frame update
    void Start()
    {

        
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000;
        rigidBody.velocity = transform.up * (GameManager.baseSpeed * delta);
       


    }


    

}
