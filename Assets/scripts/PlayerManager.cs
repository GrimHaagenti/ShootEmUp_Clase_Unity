using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    float time = 2.0f;
    public GameObject _player;
    GameObject ship;
    Rigidbody2D rigidbody;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        ship = Instantiate(_player, this.transform);
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (ship.activeSelf == true)
        {
            rigidbody.velocity = ship.GetComponent<Rigidbody2D>().velocity;
        }
        else
        {
          
            rigidbody.velocity = Vector2.zero;
            time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                Respawn();
                Debug.Log("ADADAS");
                time = 2.0f;
            }
        }
    }

    
    private void Respawn()
    {
        
        
        

        ship.SetActive(true);
 
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "Untagged")
        {
            ship.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rigidbody.velocity = Vector2.zero;
            ship.SetActive(false);
        }
        
    }
    
}
