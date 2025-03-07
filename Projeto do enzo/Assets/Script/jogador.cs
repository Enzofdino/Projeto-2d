using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public Rigidbody2D player;
    public float velocity = 5f;
    public bool pulo;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * velocity * Time.deltaTime; // Move para a esquerda
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * velocity * Time.deltaTime; // Move para a direita
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 5, 0) * velocity * Time.deltaTime;
        }
        
    }
}
