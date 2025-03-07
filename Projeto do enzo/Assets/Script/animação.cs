using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animação : MonoBehaviour
{
    [SerializeField]
    public Animator animar;

    void Start()
    {
        Debug.Log("Entrou no start");
        animar = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Entrou no W");
            //mudar

            animar.SetTrigger("Muda");

        }
        if (Input.GetKey(KeyCode.S))
        {
            animar.SetTrigger("Parado");
        }

        if (Input.GetKey(KeyCode.D))
        {
            animar.SetTrigger("Andar");
        }
         if (Input.GetKey(KeyCode.A))
        {
            animar.SetTrigger("Andar");
        }
       else if (Input.GetKey(KeyCode.None))
        {
            animar.SetTrigger("Parado");
        }


    }
}
