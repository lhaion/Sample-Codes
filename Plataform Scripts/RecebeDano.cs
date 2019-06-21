using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecebeDano : MonoBehaviour
{  
    public float danoRecebido;
    public float vidaInicial;
    public float vidaAtual;
    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaAtual <= 0){
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.GetComponent<CausaDano>().causador != this.gameObject){
            danoRecebido = other.gameObject.GetComponent<CausaDano>().danoAplicado;
            vidaAtual = vidaAtual - danoRecebido;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.GetComponent<CausaDano>().causador != this.gameObject){
            danoRecebido = other.gameObject.GetComponent<CausaDano>().danoAplicado;
            vidaAtual = vidaAtual - danoRecebido;
        }
    }
}
