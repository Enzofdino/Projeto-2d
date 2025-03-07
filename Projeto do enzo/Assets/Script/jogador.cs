using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public Rigidbody2D player;
    public float velocity = 5f;
    

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * velocity * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * velocity * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 3, 0) * velocity * Time.deltaTime;
        }
        
    }
}
