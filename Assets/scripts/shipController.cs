using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{

    enum Direction { FORWARD, BACKWARDS, STILL };
    enum Rotation { LEFT, RIGHT, NO_R };

    private Rigidbody2D rb2d;
    private Animator animator;
    private Direction shipDirection;
    private Rotation shipRotation;
    private float acceleration;
    private Vector3 forwVec;
    private Vector3 rotation;
    private int thrustParamID;
    



    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
        shipDirection = Direction.STILL;
        acceleration = 0f;
        thrustParamID = Animator.StringToHash("Thrust");

        

    }

    // Update is called once per frame
    void Update()
    {
        bool moving = false;
        if (Input.GetKey(KeyCode.UpArrow))
        {shipDirection = Direction.FORWARD; }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            shipDirection = Direction.BACKWARDS;
        }
        else
        {
            shipDirection = Direction.STILL;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation = new Vector3(0.0f, 0.0f, 3.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation = new Vector3(0.0f, 0.0f, -3.0f);
        }
        else
        {
            rotation = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(ball, transform.position, transform.rotation);
            Destroy(bullet, 1.0f);
        }


        switch (shipDirection)
        {
            case Direction.FORWARD:
                acceleration = 15f;
                moving = true;
                break;

            case Direction.BACKWARDS:
                acceleration = -10f;
                moving = false;
                break;

            case Direction.STILL:
                acceleration = 0;
                moving = false;
                break;

        }
        
        animator.SetBool(thrustParamID,moving);




        // Debug.Log(rb2d.transform.position);

    }
    void FixedUpdate()
        {
        float delta = Time.fixedDeltaTime* 100;
        rb2d.AddForce((transform.up * acceleration)*delta);

        rb2d.transform.Rotate(rotation);
        }
    
}
