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
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Entrou no W");
            //mudar
           
            animar.SetTrigger("Muda");

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animar.SetTrigger("Desmudar");
        }
    }
}
