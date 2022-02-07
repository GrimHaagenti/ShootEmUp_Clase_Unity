using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum Direction { FORWARD, BACKWARDS, UP, DOWN, NONE };



    Rigidbody2D rb2d;


    public float speed = 5.0f;
    private float currentSpeed;

    public Direction dir = Direction.NONE;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime * 1000;

        if (InputManager.Instance.ButtonPressed[(int)GameDirections.RIGHT] == true)
        {
            dir = Direction.FORWARD;
        }
        if(InputManager.Instance.ButtonReleased[(int)GameDirections.RIGHT] == true) { dir = Direction.NONE; }




        if (InputManager.Instance.ButtonPressed[(int)GameDirections.LEFT] == true)
        {
            dir = Direction.BACKWARDS;
        }
         if (InputManager.Instance.ButtonReleased[(int)GameDirections.LEFT] == true) { dir = Direction.NONE; }



        if (InputManager.Instance.ButtonPressed[(int)GameDirections.UP] == true)
            {
                dir = Direction.UP;
        }
          if (InputManager.Instance.ButtonReleased[(int)GameDirections.UP] == true) { dir = Direction.NONE; }





        if (InputManager.Instance.ButtonPressed[(int)GameDirections.DOWN] == true)
            {
                dir = Direction.DOWN;
        }
         if (InputManager.Instance.ButtonReleased[(int)GameDirections.DOWN] == true) { dir = Direction.NONE; }




    }

    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000;
        
        Vector2 motion = new Vector2(0, 0);
        if (dir == Direction.FORWARD) { 
            motion.x += speed;
        }
        if (dir == Direction.BACKWARDS) {
            motion.x -= speed;
        }
        if (dir == Direction.UP)
        {
            motion.y += speed;
        }
        if (dir == Direction.DOWN)
        {
            motion.y -= speed;
        }
       
            Debug.Log(dir);
            rb2d.velocity = motion * delta;
        
        }
    } 
