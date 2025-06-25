using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    private string nome = "Thomas";
    private int vida = 10;
    public float velocidade = 2.5f;
    private Rigidbody2D rb;
    public float novagravidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome do Personagem:" + nome + "Vida do Personagem:" + vida + "Velocidade do Personagem" + velocidade);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novagravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
