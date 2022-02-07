using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float baseSpeed = 2f;
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
        
    }
}
