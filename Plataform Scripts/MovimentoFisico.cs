using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoFisico : MonoBehaviour
{
    public Rigidbody2D fisicaDoPersonagem;
    public float velocidadeMaxima;
    public bool olhandoParaDireita;
    // Start is called before the first frame update
    void Awake()
    {
        fisicaDoPersonagem = GetComponent<Rigidbody2D>();
        olhandoParaDireita = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float velocidadeHorizontal = Input.GetAxis("Horizontal") * velocidadeMaxima;

        if (velocidadeHorizontal > 0)
            olhandoParaDireita = true;
        else if (velocidadeHorizontal < 0)
            olhandoParaDireita = false;

        GetComponent<Atirador>().olhandoParaDireita = olhandoParaDireita;

        fisicaDoPersonagem.velocity = new Vector2(velocidadeHorizontal, fisicaDoPersonagem.velocity.y);

        if(Input.GetButtonDown("Jump") && fisicaDoPersonagem.velocity.y > -0.001 && fisicaDoPersonagem.velocity.y < 0.001){
            Pulo();
        }
    }

    void Pulo(){
        fisicaDoPersonagem.AddForce(forcaImpulso, ForceMode2D.Impulse);
    }
}
