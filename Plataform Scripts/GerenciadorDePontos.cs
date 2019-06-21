using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDePontos : MonoBehaviour
{
    public int pontuacao;
    public bool ganhaPontos;
    
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.GetComponent<GerenciadorDePontos>()){
            if(other.gameObject.GetComponent<GerenciadorDePontos>().ganhaPontos == false){
                pontuacao = pontuacao + other.gameObject.GetComponent<GerenciadorDePontos>().pontuacao;
            }
        }
    }
}
