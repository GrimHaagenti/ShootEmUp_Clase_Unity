using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{

    public enum DirectionX {LEFT, RIGHT, NONEX };
    public enum DirectionY { FORWARD, BACKWARDS, LEFT, RIGHT, NONEY};



    private Rigidbody2D rb2d;
    private Animator animator;
    private DirectionX shipDirectionX;
    private DirectionY shipDirectionY;
   
    
    private Vector3 forwVec;
    private Vector3 rotation;
    private int thrustParamID;


    bool moving = false;

    public GameObject ball;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
        shipDirectionX = DirectionX.NONEX;
        shipDirectionY = DirectionY.NONEY;
      
        thrustParamID = Animator.StringToHash("Thrust");

        

    }

    // Update is called once per frame
    void Update()
    {


        if (InputManager.Instance.ButtonDown[(int)GameDirections.RIGHT] == true)
        {
            shipDirectionX = DirectionX.RIGHT;
        }
        if (InputManager.Instance.ButtonReleased[(int)GameDirections.RIGHT] == true) { shipDirectionX = DirectionX.NONEX; }




        if (InputManager.Instance.ButtonDown[(int)GameDirections.LEFT] == true)
        {
            shipDirectionX = DirectionX.LEFT;
        }
        if (InputManager.Instance.ButtonReleased[(int)GameDirections.LEFT] == true) { shipDirectionX = DirectionX.NONEX; }



        if (InputManager.Instance.ButtonDown[(int)GameDirections.UP] == true)
        {
            shipDirectionY = DirectionY.FORWARD;
        }
        if (InputManager.Instance.ButtonReleased[(int)GameDirections.UP] == true) { shipDirectionY = DirectionY.NONEY; }





        if (InputManager.Instance.ButtonDown[(int)GameDirections.DOWN] == true)
        {
            shipDirectionY = DirectionY.BACKWARDS;
        }
        if (InputManager.Instance.ButtonReleased[(int)GameDirections.DOWN] == true) { shipDirectionY = DirectionY.NONEY; }


        
        //if (Input.GetKey(KeyCode.UpArrow))
        //{shipDirection = Direction.FORWARD; }
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    shipDirection = Direction.BACKWARDS;
        //}
        //else
        //{
        //    shipDirection = Direction.STILL;
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rotation = new Vector3(0.0f, 0.0f, 3.0f);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rotation = new Vector3(0.0f, 0.0f, -3.0f);
        //}
        //else
        //{
        //    rotation = new Vector3(0.0f, 0.0f, 0.0f);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(ball, transform.position, transform.rotation,this.transform);
            Destroy(bullet, 2.0f);
            
        }

       
       


        

        animator.SetBool(thrustParamID,moving);




        // Debug.Log(rb2d.transform.position);

    }
    void FixedUpdate()
        {


        float delta = Time.fixedDeltaTime* 1000;
        Vector2 motion = new Vector2(0,0);

                    switch (shipDirectionX)
                {
                    case DirectionX.NONEX:
                        motion.x = 0;
                        moving = false;
                        break;

                    case DirectionX.LEFT:
                        motion.x = -1;
                        break;

                    case DirectionX.RIGHT:
                        motion.x = 1;
                        break;
                } 
        
                    switch (shipDirectionY)
                {
                    case DirectionY.FORWARD:
                        motion.y = 1;
                        moving = true;
                        break;

                    case DirectionY.BACKWARDS:
                        motion.y = -1;
                        moving = false;
                        break;

                    case DirectionY.NONEY:
                        motion.y = 0;
                        moving = false;
                        break;
                }
               
                motion = motion.normalized;
        Vector3 vector3 = new Vector3(motion.x * 6 * delta, (motion.y  * 70) + (transform.up.y *GameManager.baseSpeed ) * delta)  ;
        rb2d.velocity = vector3;
               

    }
    
}

