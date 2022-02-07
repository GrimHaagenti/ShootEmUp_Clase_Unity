using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum GameInputs { JUMP, RUN, SHOOT, ACCEPT,CANCEL };
enum GameDirections { NONE, UP, DOWN, LEFT, RIGHT };
public class InputManager : MonoBehaviour
{ 
    
    public static  InputManager Instance { get; private set; }

    public bool[] ButtonPressed = new bool[5];
    public bool[] ButtonDown = new bool[5];
    public bool[] ButtonReleased = new bool[5];

    KeyCode jumpButton = KeyCode.Z;
    KeyCode runButton = KeyCode.X;
    KeyCode shootButton = KeyCode.C;
    KeyCode acceptButton = KeyCode.Z;
    KeyCode cancelButton = KeyCode.X;
    KeyCode upButton = KeyCode.UpArrow;
    KeyCode downButton = KeyCode.DownArrow;
    KeyCode leftButton = KeyCode.LeftArrow;
    KeyCode rightButton = KeyCode.RightArrow;


    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            
            Instance = this;
            DontDestroyOnLoad(this);

        }
        else { Destroy(this.gameObject); }


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            ButtonDown[i] = false;
            ButtonPressed[i] = false;
            ButtonReleased[i] = false;
        }

        if (Input.GetKey(jumpButton)){ButtonDown[(int)GameInputs.JUMP] = true;}
        if (Input.GetKeyDown(jumpButton)){ButtonPressed[(int)GameInputs.JUMP] = true;}
        if (Input.GetKeyUp(jumpButton)){ButtonReleased[(int)GameInputs.JUMP] = true;}

         if (Input.GetKey(runButton)){ButtonDown[(int)GameInputs.RUN] = true;}
        if (Input.GetKeyDown(runButton)){ButtonPressed[(int)GameInputs.RUN] = true;}
        if (Input.GetKeyUp(runButton)){ButtonReleased[(int)GameInputs.RUN] = true; }

         if (Input.GetKey(shootButton)){ButtonDown[(int)GameInputs.SHOOT] = true;}
        if (Input.GetKeyDown(shootButton)){ButtonPressed[(int)GameInputs.SHOOT] = true;}
        if (Input.GetKeyUp(shootButton)){ButtonReleased[(int)GameInputs.SHOOT] = true; }

         if (Input.GetKey(acceptButton)){ButtonDown[(int)GameInputs.ACCEPT] = true;}
        if (Input.GetKeyDown(acceptButton)){ButtonPressed[(int)GameInputs.ACCEPT] = true;}
        if (Input.GetKeyUp(acceptButton)){ButtonReleased[(int)GameInputs.ACCEPT] = true; }

         if (Input.GetKey(cancelButton)){ButtonDown[(int)GameInputs.CANCEL] = true;}
        if (Input.GetKeyDown(cancelButton)){ButtonPressed[(int)GameInputs.CANCEL] = true;}
        if (Input.GetKeyUp(cancelButton)){ButtonReleased[(int)GameInputs.CANCEL] = true; }


        if (Input.GetKey(upButton)) { ButtonDown[(int)GameDirections.UP] = true; }
        if (Input.GetKeyDown(upButton)) { ButtonPressed[(int)GameDirections.UP] = true; }
        if (Input.GetKeyUp(upButton)) { ButtonReleased[(int)GameDirections.UP] = true; }

        if (Input.GetKey(downButton)) { ButtonDown[(int)GameDirections.DOWN] = true; }
        if (Input.GetKeyDown(downButton)) { ButtonPressed[(int)GameDirections.DOWN] = true; }
        if (Input.GetKeyUp(downButton)) { ButtonReleased[(int)GameDirections.DOWN] = true; }

        if (Input.GetKey(leftButton)) { ButtonDown[(int)GameDirections.LEFT] = true; }
        if (Input.GetKeyDown(leftButton)) { ButtonPressed[(int)GameDirections.LEFT] = true; }
        if (Input.GetKeyUp(leftButton)) { ButtonReleased[(int)GameDirections.LEFT] = true; }

        if (Input.GetKey(rightButton)) { ButtonDown[(int)GameDirections.RIGHT] = true; }
        if (Input.GetKeyDown(rightButton)) { ButtonPressed[(int)GameDirections.RIGHT] = true; }
        if (Input.GetKeyUp(rightButton)) { ButtonReleased[(int)GameDirections.RIGHT] = true; }


    }
}
