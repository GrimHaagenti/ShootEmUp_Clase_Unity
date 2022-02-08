using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject _player;
    GameObject ship;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        ship = Instantiate(_player, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = ship.GetComponent<Rigidbody2D>().velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ASFASFASFAS");
    }

}
