using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    // identifica se algum gameObject colidiu com o Trigger da moeda
    void OnTriggerEnter2D(Collider2D other)
    {
        // verifica se o gameObject que colidiu com a moeda foi o Jogador
        if(other.gameObject.CompareTag("Player"))
        {
            // acessa o script do Jogador e roda o método GanharMoeda()
            other.gameObject.GetComponent<Jogador>().GanharMoeda();
            // destrói o gameObject da moeda
            Destroy(this.gameObject);
        }
    }
}
