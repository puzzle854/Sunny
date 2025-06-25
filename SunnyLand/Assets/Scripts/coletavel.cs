using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletavel : MonoBehaviour
{

    private int pontos = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jogo Começou! Você tem:\n" + pontos + "pontos!");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Jogo Rodando!");

    }

    private void OntiggrerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("yes");
        }
    }
}
