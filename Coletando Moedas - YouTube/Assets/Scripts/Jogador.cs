using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // referência ao componente 'Rigidbody 2D' do jogador
    public Rigidbody2D oRigidbody2D;

    // controle da velocidade do jogador
    public float velocidadeDoJogador;

    // controle da quantidade de moedas que o jogador coletou
    public int moedasColetadas;

    void Start()
    {
        // zera o valor salvo no computador das moedas coletadas
        // PlayerPrefs.SetInt("MoedasColetadas", 0);

        // pede para a Unity iniciar o jogo com as moedas que já coletamos anteriormente
        moedasColetadas = PlayerPrefs.GetInt("MoedasColetadas");
    }

    // Update is called once per frame
    void Update()
    {
        // roda o método 'MovimentarJogador'
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {
         // movimenta o jogador no eixo horizontal, se baseando na sua velocidade
        oRigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidadeDoJogador, oRigidbody2D.velocity.y);

         // verifica se o jogador está indo para a esquerda
        if(Input.GetAxis("Horizontal") < 0)
        {
            // ativa o espelhamento do sprite do jogador
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(Input.GetAxis("Horizontal") > 0)    // verifica se o jogador está indo para a direita
        {
            // desativa o espelhamento do sprite do jogador
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    public void GanharMoeda()
    {
        // aumenta em 1 a quantidade de moedas coletadas
        moedasColetadas += 1;
        // salva no computador a quantidade atual de moedas
        PlayerPrefs.SetInt("MoedasColetadas", moedasColetadas);
    }
}